using GameEnergy.CustomControls;
using GameEnergy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameEnergy.AppForms.UserForms
{
    public partial class CartForm : Form
    {
        int _curentUser = Program.CurrentUser.UserRoleID;

        public CartForm()
        {
            InitializeComponent();

            LoadCartAndOrderInfo();
        }

        private void LoadCartInfo()
        {
            var cart = Program.context.Cart.FirstOrDefault(u => u.UserID == _curentUser);
            var cartItems = Program.context.CartItems.Where(ci => ci.CartID == cart.CartID);

            cartCountLabel.Text = cartItems.Count().ToString();
            totalPriceLabel.Text = cart.TotalAmount.ToString();
            payButton.Text = $"Оплатить {cart.TotalAmount}₽";

            ShowCart();
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

            var cartItems = Program.context.CartItems.Where(ci => ci.CartID == cart.CartID).ToList();

            for (int i = 0; i < cartItems.Count; i++)
            {
                var item = cartItems[i];

                // Добавляем сам комментарий
                var cartControl = new CartControl(item);
                cartControl.Margin = new Padding(10);
                cartPanel.Controls.Add(cartControl);

                var separator = new Panel
                {
                    Size = new Size(495, 1),
                    Dock = DockStyle.Top,
                    BackColor = Color.Gray,
                    Margin = new Padding(15, 0, 10, 10)
                };
                cartPanel.Controls.Add(separator);
            }

            // Принудительно обновляем layout
            cartPanel.PerformLayout();
        }

        private void LoadOrderInfo()
        {

        }

        private void LoadCartAndOrderInfo()
        {
            LoadCartInfo();
            LoadOrderInfo();
        }
    }
}
