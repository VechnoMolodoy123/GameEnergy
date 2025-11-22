using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Images.InstallingImages;
using GameEnergy.Classes.Video;
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

namespace GameEnergy.AppForms.UserForms
{
    public partial class GameInfoForm : Form
    {
        Games _game;
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isUserAdmin = false;

        public GameInfoForm(Games game)
        {
            InitializeComponent();

            _game = game;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            infoPanel.Height = 526;

            LoadGameInfo();
            CheckUserRole();
        }

        private void LoadGameInfo()
        {
            genreLabel.Text = _game.Genres?.Any() == true ? string.Join(", ", _game.Genres.Select(g => g.GenreName)) : "";
            dateLabel.Text = _game.ReleaseDate?.ToString("d MMMM yyyy", new System.Globalization.CultureInfo("ru-RU"));
            developerLabel.Text = _game.GameDevelopers.DeveloperName?.ToString();
            titleLabel.Text = _game.Title?.ToString();
            priceLabel.Text = _game.DiscountedPrice.HasValue ? $"{_game.DiscountedPrice} ₽" : $"{_game.Price} ₽";
            discountLabel.Text = _game.Discount.HasValue ? $"-{_game.Discount}%" : "";
            descriptionLabel.Text = _game.Description != null ? _game.Description : "";


            TrailerHelper.LoadTrailerPreview(trailerPictureBox, _game.TrailerImage);

            Image image = ImageLoader.LoadGameImage(_game.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }

            likeButtonLogic();
        }

        private void likeButtonLogic()
        {
            //likeButton.Image = 
        }

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (_currentUser != null)
            {
                reportButton.Text = "Удалить";
                _isUserAdmin = true;
            }
        }

        private int CalculateLabelHeight(string text, Font font, int width)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(text, font, new Size(width, 0), TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height);
            }
        }

        private void DescriptionLabel_TextChanged(object sender, EventArgs e)
        {
            int labelWidth = descriptionLabel.Width;

            int preferredHeight = CalculateLabelHeight(descriptionLabel.Text, descriptionLabel.Font, labelWidth);

            descriptionLabel.Height = preferredHeight;

            descriptionPanel.PerformLayout();
        }

        private void GameInfoForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                navigationControl.LeftPanelWidth = 500;
                navigationControl.RightPanelWidth = 500;
                imagePanel.Width = 255;
                gameImage.Height = 317;
                delimiterPanel3.Width = 30;
                trailerPictureBox.Height = 336;
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
                imagePanel.Width = 170;
                gameImage.Height = 211;
                delimiterPanel3.Width = 16;
                trailerPictureBox.Height = 180;
            }

            navigationControl.UpdatePanelsWidth();
            DescriptionLabel_TextChanged(descriptionLabel, EventArgs.Empty);
        }

        private void trailerPictureBox_Click(object sender, EventArgs e)
        {
            TrailerHelper.ShowTrailer(_game.TrailerImage);
        }

        private void GameInfoForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void GameInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
