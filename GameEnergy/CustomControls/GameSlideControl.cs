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
    public partial class GameSlideControl : UserControl
    {
        private int _gameID;
        private string _titleOverride;
        public event EventHandler<Games> GameClicked;

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

                string baseName = game.Title + "Slide";

                string resourceName = ToResourceName(baseName);

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

        public void UpdateContent(int gameID, string titleOverride)
        {
            _gameID = gameID;
            _titleOverride = titleOverride;
            LoadGameInfo(); // перезагружает текст и изображение
        }

        private string ToResourceName(string fileName)
        {
            // Заменяем недопустимые символы на подчёркивания
            return System.Text.RegularExpressions.Regex.Replace(fileName, @"[^a-zA-Z0-9_]", "_");
        }

        private void GameSlideControl_Click(object sender, EventArgs e)
        {
            var game = Program.context.Games.FirstOrDefault(g => g.GameID == _gameID);
            GameClicked?.Invoke(this, game);
        }
    }
}
