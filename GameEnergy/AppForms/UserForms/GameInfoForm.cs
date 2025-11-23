using GameEnergy.AppForms.AdminForms;
using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Images.InstallingImages;
using GameEnergy.Classes.Messages;
using GameEnergy.Classes.Validation;
using GameEnergy.Classes.Video;
using GameEnergy.CustomControls;
using GameEnergy.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.AppForms.UserForms
{
    public partial class GameInfoForm : Form
    {
        Games _game;
        private int CurrentRating = 0;
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isUserAdmin = false;
        private string _currentSortMode = "new";

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

            infoPanel.Height = 461;

            LoadGameInfo();
            CheckUserRole();
            CheckIfReviewExists();
            UpdateLikeButtonState();
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
            ratingLabel.Text = ((double)_game.AverageRating).ToString("F1", CultureInfo.InvariantCulture);

            if (_game.DiscountedPrice != _game.Price)
            {
                oldPriceLabel.Text = $"{ _game.Price?.ToString()} ₽";
                oldPriceLabel.Visible = true;
            }

            RoundingHelper.SetRoundedRegion(ratingPanel, 12, 12);
            

            TrailerHelper.LoadTrailerPreview(trailerPictureBox, _game.TrailerImage);

            Image image = ImageLoader.LoadGameImage(_game.GameImage);

            if (image != null)
            {
                gameImage.Image = image;
            }
        }

        private int GetStarIndex(PictureBox star)
        {
            if (star == star1) return 1;
            if (star == star2) return 2;
            if (star == star3) return 3;
            if (star == star4) return 4;
            if (star == star5) return 5;
            return 0;
        }

        private void UpdateStars(int selected)
        {
            PictureBox[] stars = { star1, star2, star3, star4, star5 };
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = i < selected ? Properties.Resources.yellowStar : Properties.Resources.star;
            }
        }

        private void CheckUserRole()
        {
            var _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId && user.UserRoleID != 1);

            if (_currentUser != null)
            {
                reportButton.Text = "Изменить";
                deleteButton.Visible = true;
                _isUserAdmin = true;
            }
        }

        private void CheckIfReviewExists()
        {
            var existingReview = Program.context.Reviews
                .FirstOrDefault(r => r.UserID == _currentUserId && r.GameID == _game.GameID);

            if (existingReview != null)
            {
                delimiterPanel5.Visible = false;
                reviewPanel.Visible = false;
            }
        }

        private void UpdateLikeButtonState()
        {
            bool isInLibrary = Program.context.UserLibrary
                .Any(ul => ul.UserID == _currentUserId && ul.GameID == _game.GameID);

            likeButton.Image = isInLibrary
                ? Properties.Resources.redLike
                : Properties.Resources.whiteLike;
        }

        private void SendCommentLogic()
        {
            commentPanel.BorderColor = Color.Gray;

            if (CurrentRating == 0)
            {
                commentPanel.BorderColor = Color.Red;
                return;
            }

            string comment = commentTextBox.Text;
            int length = comment.Length;

            if (length < 50 || length > 1000)
            {
                commentPanel.BorderColor = Color.Red;
                return;
            }

            try
            {
                var existingRating = Program.context.Rating
                    .FirstOrDefault(r => r.UserID == _currentUserId && r.GameID == _game.GameID);

                if (existingRating != null)
                {
                    existingRating.Rating1 = CurrentRating;
                }
                else
                {
                    var newRating = new Rating
                    {
                        UserID = _currentUserId,
                        GameID = _game.GameID,
                        Rating1 = CurrentRating
                    };
                    Program.context.Rating.Add(newRating);
                }

                var existingReview = Program.context.Reviews
                    .FirstOrDefault(r => r.UserID == _currentUserId && r.GameID == _game.GameID);

                if (existingReview != null)
                {
                    existingReview.Comment = comment;
                    existingReview.ReviewDate = DateTime.Now;
                }
                else
                {
                    var newReview = new Reviews
                    {
                        UserID = _currentUserId,
                        GameID = _game.GameID,
                        Comment = comment,
                        LikesCount = 0,
                        ReviewDate = DateTime.Now
                    };
                    Program.context.Reviews.Add(newReview);
                }

                Program.context.SaveChanges();

                delimiterPanel5.Visible = false;
                reviewPanel.Visible = false;
            }
            catch (Exception ex)
            {
                string logPath = "errorUserReviews_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при отправке отзыва: {ex.Message}\n");
            }
        }

        private void likeButtonLogic()
        {
            bool isInLibrary = Program.context.UserLibrary.Any(ul => ul.UserID == _currentUserId && ul.GameID == _game.GameID);

            try
            {
                if (isInLibrary)
                {
                    var entryToRemove = Program.context.UserLibrary
                        .First(ul => ul.UserID == _currentUserId && ul.GameID == _game.GameID);

                    Program.context.UserLibrary.Remove(entryToRemove);
                }
                else
                {
                    var newEntry = new UserLibrary
                    {
                        UserID = _currentUserId,
                        GameID = _game.GameID,
                        AddedDate = DateTime.Now
                    };
                    Program.context.UserLibrary.Add(newEntry);
                }

                Program.context.SaveChanges();

                UpdateLikeButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении избранного: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowComments(Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> sortingFunction = null)
        {
            commentsPanel.Controls.Clear();

            DateTime now = DateTime.Now;

            IQueryable<Reviews> query = Program.context.Reviews.Where(game => game.GameID == _game.GameID);

            IOrderedQueryable<Reviews> orderedQuery = sortingFunction != null ?
                sortingFunction(query) :
                query.OrderByDescending(date => date.ReviewDate);

            List<Reviews> comments = orderedQuery.ToList();

            foreach (Reviews comment in comments)
            {
                var commentControl = new UserCommentsControl(this, comment);
                commentControl.Margin = new Padding(10);
                commentsPanel.Controls.Add(commentControl);
            }
        }

        private void DeleteGame()
        {
            var bookToRemove = Program.context.Games.Find(_game.GameID);

            if (bookToRemove != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту игру?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Program.context.Games.Remove(bookToRemove);
                        Program.context.SaveChanges();

                        MessageHelper.ShowInformationMessage("Книга успешно удалена", "Успех");

                        var mainform = new MainForm();
                        VisibilityHelper.ShowNewForm(this, mainform);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowErrorMessage("Произошла ошибка при удалении книги: " + ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageHelper.ShowErrorMessage("Книга не найдена в базе данных.");
            }
        }

        private void SetActiveButton(Guna2Button activeButton, Guna2Button inactiveButton)
        {
            activeButton.Checked = true;

            inactiveButton.Checked = false;
        }

        private void SortCommentsByDate()
        {
            ShowComments(q => q.OrderByDescending(date => date.ReviewDate));
        }

        private void SortCommentsByLikes()
        {
            ShowComments(q => q.OrderByDescending(comment => comment.LikesCount).ThenByDescending(date => date.ReviewDate));
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
                infoPanel.Height = 461;
                imagePanel.Width = 255;
                gameImage.Height = 317;
                ratingPanel.Location = new Point(210, 5);
                delimiterPanel3.Width = 30;
                trailerPictureBox.Height = 336;
                commentPanel.Width = 899;
                commentTextBox.Width = 860;
                sendCommentButton.Location = new Point(870, 3);
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
                infoPanel.Height = 355;
                imagePanel.Width = 170;
                gameImage.Height = 211;
                ratingPanel.Location = new Point(125, 5);
                delimiterPanel3.Width = 16;
                trailerPictureBox.Height = 180;
                commentPanel.Width = 505;
                commentTextBox.Width = 466;
                sendCommentButton.Location = new Point(476, 3);
            }

            navigationControl.UpdatePanelsWidth();
            DescriptionLabel_TextChanged(descriptionLabel, EventArgs.Empty);

            this.BeginInvoke(new Action(() =>
            {
                RoundingHelper.SetRoundedRegion(trailerPictureBox, 12, 12);
            }));
        }

        private void Star_Click(object sender, EventArgs e)
        {
            var clickedStar = sender as PictureBox;
            if (clickedStar == null) return;

            int index = GetStarIndex(clickedStar);
            CurrentRating = index;
            UpdateStars(index);
        }

        private void sortNewCommentButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "new") return;

            SetActiveButton(sortNewCommentButton, sortInterestingCommentButton);
            _currentSortMode = "new";
            SortCommentsByDate();
        }

        private void sortInterestingCommentButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "interesting") return;

            SetActiveButton(sortInterestingCommentButton, sortNewCommentButton);
            _currentSortMode = "interesting";
            SortCommentsByLikes();
        }

        private void SendCommentButton_Click(object sender, EventArgs e)
        {
            SendCommentLogic();
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            likeButtonLogic();
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

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (_isUserAdmin)
            {
                var form = new CreateOrUpdateGameForm(_game);
                form.GameUpdated += LoadGameInfo;
                form.ShowDialog();
                form.GameUpdated -= LoadGameInfo;
            }
            else
            {
                var form = new GameReportForm(_game, _currentUserId);
                form.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteGame();
        }
    }
}
