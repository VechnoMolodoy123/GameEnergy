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
        int _curentUser = Program.CurrentUser.UserRoleID;

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
            var cart = Program.context.Cart.AsNoTracking().FirstOrDefault(u => u.UserID == _curentUser);
            var cartItems = Program.context.CartItems.AsNoTracking().Where(ci => ci.CartID == cart.CartID);

            cartCountLabel.Text = cartItems.Count().ToString();
            totalPriceLabel.Text = cart.TotalAmount.ToString();
            payButton.Text = $"Оплатить {cart.TotalAmount}₽";

            ShowCart();
            navigationControl.UpdateNotificationsCount();
        }

        private void LoadOrderInfo()
        {

        }

        private void ShowCart()
        {
            cartPanel.Controls.Clear();

            var cart = Program.context.Cart.FirstOrDefault(u => u.UserID == _curentUser);

            if (cart == null)
            {
                return;
            }

            int cartId = cart.CartID;

            List<CartItems> items = Program.context.CartItems.Where(ci => ci.CartID == cart.CartID).ToList();

            foreach (CartItems item in items)
            {
                var cartControl = new CartAndOrderControl(item);
                cartControl.Margin = new Padding(10);
                cartPanel.Controls.Add(cartControl);
            }
        }

        private void OrderingLogic()
        {
            // Если у пользователя на текущий момент нету товаров в корзине (CartItems.Count = 0), то мы устанавливаем payButton.Enable = false
            // При нажатии на эту кнопку открой ссылку: https://i-mg24.ru/images/112625213619-wy9eo.png
            // Затем добавь эту карзину (Cart) в заказ (Order), а элементы корзины (CartItems) добавь в таблицу OrderItems, после создания заказа очисти данные которые были в таблицах Cart и CartItems у этого пользователя.
            // А затем установи CartAndOrderTabControl.SelectedIndex = 1;
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
