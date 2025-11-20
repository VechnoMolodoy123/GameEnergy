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

namespace GameEnergy.CustomControls
{
    public partial class GameSlideControl : UserControl
    {
        private int _gameID;
        private string _titleOverride;

        public GameSlideControl(int gameID, string titleOverride)
        {
            InitializeComponent();

            _gameID = gameID;
            _titleOverride = titleOverride;

            LoadGameInfo();
        }

        private void LoadGameInfo()
        {
            try
            {
                var game = Program.context.Games.FirstOrDefault(g => g.GameID == _gameID);
                string imageName = game.GameImage + "Slide";

                if (game == null)
                {
                    headerLabel.Text = "Игра не найдена";
                    priceLabel.Text = "0 ₽";
                    discountLabel.Text = "-0%";
                    gameImage.Image = Properties.Resources.DefaultGameImage;
                    return;
                }

                headerLabel.Text = _titleOverride;
                priceLabel.Text = game.DiscountedPrice.HasValue ? $"{game.DiscountedPrice} ₽" : $"{game.Price} ₽";
                discountLabel.Text = game.Discount.HasValue ? $"-{game.Discount}%" : "";

                string resourceName = game.GameImage + "Slide";

                var resourceManager = Properties.Resources.ResourceManager;
                var image = resourceManager.GetObject(resourceName) as Image;

                gameImage.Image = image ?? Properties.Resources.DefaultGameImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в GamePromoSlide: {ex.Message}");
                gameImage.Image = Properties.Resources.DefaultGameImage;
            }
        }
    }
}
