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
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.CustomControls
{
    public partial class MainGameControl : UserControl
    {
        private Games _game;
        public event EventHandler<Games> GameClicked;

        public MainGameControl(Games game)
        {
            InitializeComponent();

            _game = game;

            LoadGameInfo();
        }

        private void LoadGameInfo()
        {
            if (_game == null)
            {
                titleLabel.Text = "Игра не найдена";
                priceLabel.Text = "0 ₽";
                discountLabel.Text = "-0%";
                gameImage.Image = Properties.Resources.DefaultGameImage;
                return;
            }

            titleLabel.Text = _game.Title;
            priceLabel.Text = _game.DiscountedPrice.HasValue ? $"{_game.DiscountedPrice} ₽" : $"{_game.Price} ₽";
            discountLabel.Text = _game.Discount.HasValue ? $"-{_game.Discount}%" : "";

            Image image = ImageLoader.LoadGameImage(_game.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }
        }

        private void MainGameControl_Click(object sender, EventArgs e)
        {
            GameClicked?.Invoke(this, _game);
        }
    }
}
