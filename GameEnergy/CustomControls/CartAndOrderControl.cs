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
    public partial class CartAndOrderControl : UserControl
    {
        CartItems _item;
        bool _Discount;

        public CartAndOrderControl(CartItems item, bool Discount = true)
        {
            InitializeComponent();

            _item = item;
            _Discount = Discount;

            LoadItemInfo();
        }

        private void LoadItemInfo()
        {
            titleLabel.Text = _item.Games.Title;
            priceLabel.Text = _item.Games.DiscountedPrice.HasValue ? $"{_item.Games.DiscountedPrice} ₽" : $"{_item.Games.Price} ₽";

            Image image = ImageLoader.LoadGameImage(_item.Games.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }

            if (_Discount)
            {
                deleteButton.Visible = true;
                oldPriceLabel.Visible = true;
                discountLabel.Visible = true;

                discountLabel.Text = _item.Games.Discount.HasValue ? $"-{_item.Games.Discount}%" : "";

                if (_item.Games.DiscountedPrice != _item.Games.Price)
                {
                    oldPriceLabel.Text = $"{_item.Games.Price?.ToString()} ₽";
                    oldPriceLabel.Visible = true;
                }
                else
                    oldPriceLabel.Visible = false;
            }
        }

        private void DeleteThisItem()
        {
            try
            {
                // Удаляем элемент из CartItems
                var itemToRemove = Program.context.CartItems
                    .FirstOrDefault(ci => ci.CartItemID == _item.CartItemID);

                if (itemToRemove != null)
                {
                    Program.context.CartItems.Remove(itemToRemove);
                    Program.context.SaveChanges();

                    // Удаляем сам контрол из родительской панели
                    this.Parent?.Controls.Remove(this);
                    this.Dispose();

                    // Опционально: обновить общую сумму в корзине (если отображается)
                    if (this.ParentForm is CartAndOrderForm cartForm)
                    {
                        cartForm.LoadCartInfo(); // вы должны реализовать этот метод в CartForm
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при удалении из корзины",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteThisItem();
        }

        private void gameImage_Click(object sender, EventArgs e)
        {
            var gameInfoForm = new GameInfoForm(_item.Games);
            VisibilityHelper.ShowNewForm(this.ParentForm, gameInfoForm);
            this.ParentForm.Hide();
        }
    }
}
