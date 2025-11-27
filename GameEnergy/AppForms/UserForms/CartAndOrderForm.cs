using GameEnergy.Classes.Customization;
using GameEnergy.CustomControls;
using GameEnergy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameEnergy.AppForms.UserForms
{
    public partial class CartAndOrderForm : Form
    {
        int _currentUserId = Program.CurrentUser.UserID;

        public CartAndOrderForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(cart, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(orders, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            LoadCartAndOrderInfo();
        }

        public void LoadCartInfo()
        {
            var cart = Program.context.Cart.AsNoTracking().FirstOrDefault(u => u.UserID == _currentUserId);
            var cartItems = Program.context.CartItems.AsNoTracking().Where(ci => ci.CartID == cart.CartID).ToList();

            cartCountLabel.Text = cartItems.Count().ToString();
            totalPriceLabel.Text = cart.TotalAmount.ToString();
            payButton.Text = $"Оплатить {cart.TotalAmount}₽";

            if (cart == null || cartItems.Count == 0)
            {
                payButton.Enabled = false;
            }
            else
                payButton.Enabled = true;

            ShowCart();
            navigationControl.UpdateNotificationsCount();
        }

        private void LoadOrderInfo()
        {

        }

        private void ShowCart()
        {
            cartPanel.Controls.Clear();

            var cart = Program.context.Cart.FirstOrDefault(u => u.UserID == _currentUserId);

            if (cart == null)
            {
                return;
            }

            int cartId = cart.CartID;

            List<CartItems> items = Program.context.CartItems.Where(ci => ci.CartID == cart.CartID).ToList();

            foreach (CartItems item in items)
            {
                var cartControl = new CartAndOrderItemsControl(item);
                cartControl.Margin = new Padding(10);
                cartPanel.Controls.Add(cartControl);
            }
        }

        private void OrderingLogic()
        {
            // 1. Проверяем, есть ли корзина и товары
            var cart = Program.context.Cart
                .FirstOrDefault(c => c.UserID == _currentUserId);

            if (cart == null)
            {
                payButton.Enabled = false;
                return;
            }

            var cartItems = Program.context.CartItems
                .Where(ci => ci.CartID == cart.CartID)
                .ToList();

            if (cartItems.Count == 0)
            {
                payButton.Enabled = false;
                return;
            }

            try
            {
                // 2. Открываем QR-код (имитация оплаты)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://i-mg24.ru/images/112625213619-wy9eo.png",
                    UseShellExecute = true
                });

                // 3. Создаём заказ
                var order = new Orders
                {
                    UserID = _currentUserId,
                    OrderDate = DateTime.Now,
                    TotalAmount = cart.TotalAmount
                };
                Program.context.Orders.Add(order);
                Program.context.SaveChanges(); // чтобы получить OrderID

                // 4. Переносим товары в OrderItems
                foreach (var item in cartItems)
                {
                    var orderItem = new OrderItems
                    {
                        OrderID = order.OrderID,
                        GameID = item.GameID,
                        PriceAtPurchase = item.PriceAtAdd,
                        GameKey = GenerateGameKey()
                    };
                    Program.context.OrderItems.Add(orderItem);
                }

                // 5. Удаляем корзину (CartItems удалятся автоматически через CASCADE)
                Program.context.Cart.Remove(cart);
                Program.context.SaveChanges();

                // 6. Переключаем вкладку на "Заказы"
                if (this.Controls.Find("CartAndOrderTabControl", true).FirstOrDefault() is Guna.UI2.WinForms.Guna2TabControl tabControl)
                {
                    tabControl.SelectedIndex = 1;
                }

                // 7. Обновляем UI
                LoadOrderInfo();
            }
            catch
            {
                MessageBox.Show("Ошибка при оформлении заказа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateGameKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var keyParts = new string[4];

            for (int i = 0; i < 4; i++)
            {
                var part = new char[4];
                for (int j = 0; j < 4; j++)
                {
                    part[j] = chars[random.Next(chars.Length)];
                }
                keyParts[i] = new string(part);
            }

            return string.Join("-", keyParts);
        }

        private void LoadCartAndOrderInfo()
        {
            LoadCartInfo();
            LoadOrderInfo();
        }

        private void CartAndOrderForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            OrderingLogic();
        }

        private void CartAndOrderForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                navigationControl.LeftPanelWidth = 420;
                navigationControl.RightPanelWidth = 420;
                grayLine.Width = 1020;
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
                grayLine.Width = 512;
            }

            navigationControl.UpdatePanelsWidth();
        }
    }
}
