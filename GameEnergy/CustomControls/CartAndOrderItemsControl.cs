using GameEnergy.AppForms.UserForms;
using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Images.InstallingImages;
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

namespace GameEnergy.CustomControls
{
    public partial class CartAndOrderItemsControl : UserControl
    {
        CartItems _cartItem;
        OrderItems _orderItem;
        String _tipe;

        public CartAndOrderItemsControl(CartItems cartitem)
        {
            InitializeComponent();

            _cartItem = Program.context.CartItems.AsNoTracking().FirstOrDefault(ci => ci.CartItemID == cartitem.CartItemID);
            _tipe = "cart";

            LoadItemInfo();
        }

        public CartAndOrderItemsControl(OrderItems orderItem)
        {
            InitializeComponent();

            _orderItem = orderItem;
            _tipe = "order";

            LoadFromOrder();
        }

        private void LoadItemInfo()
        {
            
            titleLabel.Text = _cartItem.Games.Title;
            priceLabel.Text = _cartItem.Games.DiscountedPrice.HasValue ? $"{_cartItem.Games.DiscountedPrice} ₽" : $"{_cartItem.Games.Price} ₽";

            Image image = ImageLoader.LoadGameImage(_cartItem.Games.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }

            deleteButton.Visible = true;
            oldPriceLabel.Visible = true;
            discountLabel.Visible = true;

            discountLabel.Text = _cartItem.Games.Discount.HasValue ? $"-{_cartItem.Games.Discount}%" : "";

            if (_cartItem.Games.DiscountedPrice != _cartItem.Games.Price)
            {
                oldPriceLabel.Text = $"{_cartItem.Games.Price?.ToString()} ₽";
                oldPriceLabel.Visible = true;
            }
            else
                oldPriceLabel.Visible = false;
        }

        private void DeleteThisItem()
        {
            try
            {
                // Удаляем элемент из CartItems
                var itemToRemove = Program.context.CartItems
                    .FirstOrDefault(ci => ci.CartItemID == _cartItem.CartItemID);

                if (itemToRemove != null)
                {
                    Program.context.CartItems.Remove(itemToRemove);
                    Program.context.SaveChanges();

                    if (this.ParentForm is CartAndOrderForm cartForm)
                    {
                        cartForm.LoadCartInfo();
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка при удалении из корзины",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadFromOrder()
        {
            var game = Program.context.Games.Find(_orderItem.GameID);

            titleLabel.Text = game.Title;
            priceLabel.Text = game.DiscountedPrice.HasValue ? $"{game.DiscountedPrice} ₽" : $"{game.Price} ₽";

            Image image = ImageLoader.LoadGameImage(game.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }

            keyButton.Visible = true;
            keyButton.Text = _orderItem.GameKey;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteThisItem();
        }

        private void gameImage_Click(object sender, EventArgs e)
        {
            if (_tipe == "cart")
            {
                var gameInfoForm = new GameInfoForm(_cartItem.Games);
                VisibilityHelper.ShowNewForm(this.ParentForm, gameInfoForm);
                this.ParentForm.Hide();
            }
            else
            {
                var gameInfoForm = new GameInfoForm(_orderItem.Games);
                VisibilityHelper.ShowNewForm(this.ParentForm, gameInfoForm);
                this.ParentForm.Hide();
            }
        }

        private async void keyButton_Click(object sender, EventArgs e)
        {
            var button = sender as Guna.UI2.WinForms.Guna2Button;
            if (button == null) return;

            string originalText = button.Text;
            Clipboard.SetText(originalText);

            button.Text = "Код активации скопирован";

            // Ждём 2 секунды
            await Task.Delay(2000);

            // Возвращаем исходный текст (только если текст не изменился вручную за это время)
            if (button.Text == "Код активации скопирован")
            {
                button.Text = originalText;
            }
        }
    }
}
