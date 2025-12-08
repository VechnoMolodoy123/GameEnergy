using GameEnergy.AppForms.UserForms;
using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Images.InstallingImages;
using GameEnergy.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameEnergy.CustomControls
{
    public partial class UserCommentsControl : UserControl
    {
        private readonly Form _parentForm;
        private Reviews _comment;
        private int _currentUserId = Program.CurrentUser.UserID;
        private bool _isLiked;

        public UserCommentsControl(Form parentForm, Reviews reviews)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _comment = reviews;

            LoadCommentInfo();
        }

        private void LoadCommentInfo()
        {
            int user = (int)_comment.UserID;

            ImageLoader.LoadAvatarImageFromUserID(user, avatarPictureBox);

            nameLabel.Text = _comment.Users.Username;
            dateLabel.Text = _comment.ReviewDate?.ToString("d MMMM yyyy 'в' HH:mm",
                new System.Globalization.CultureInfo("ru-RU")) ?? "";
            commentLabel.Text = _comment.Comment;
            LoadUserRatingForComment();
            likesCountLabel.Text = _comment.LikesCount.ToString();

            _isLiked = Program.context.Likes.Any(like => like.UserID == _currentUserId && like.ReviewID == _comment.ReviewID);

            UpdateLikeButtonImage();
        }

        private void UpdateLikeButtonImage()
        {
            likesButton.Image = _isLiked ? Properties.Resources.redLike : Properties.Resources.whiteLike;
        }

        private int CalculateLabelHeight(string text, Font font, int width)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF textSize = TextRenderer.MeasureText(text, font, new Size(width, 0), TextFormatFlags.WordBreak);

                return (int)Math.Ceiling(textSize.Height);
            }
        }

        private void ToggleLike()
        {
            var like = Program.context.Likes.FirstOrDefault(userLike => userLike.UserID
            == _currentUserId && userLike.ReviewID
            == _comment.ReviewID);

            var review = Program.context.Reviews.FirstOrDefault(r => r.ReviewID == _comment.ReviewID);
            if (review == null) return;

            if (like == null)
            {
                like = new Likes
                {
                    UserID = _currentUserId,
                    ReviewID = _comment.ReviewID,
                    isLiked = 1
                };

                Program.context.Likes.Add(like);
                _isLiked = true;
                review.LikesCount++;
            }
            else
            {
                Program.context.Likes.Remove(like);
                _isLiked = false;
                review.LikesCount = Math.Max(0, (int)review.LikesCount - 1);
            }

            Program.context.SaveChanges();
            UpdateLikeButtonImage();
            likesCountLabel.Text = review.LikesCount.ToString();
        }

        private void LoadUserRatingForComment()
        {
            if (_comment == null) return;

            // Ищем оценку в таблице Rating
            var userRating = Program.context.Rating
                .FirstOrDefault(r => r.UserID == _comment.UserID && r.GameID == _comment.GameID);

            int ratingValue = userRating?.Rating1 ?? 0; // 0, если оценки нет

            // Массив звёзд для удобства
            PictureBox[] stars = { star1, star2, star3, star4, star5 };

            // Обновляем каждую звезду
            for (int i = 0; i < stars.Length; i++)
            {
                if (i < ratingValue)
                {
                    stars[i].Image = Properties.Resources.yellowStar; // Заполненная
                }
                else
                {
                    stars[i].Image = Properties.Resources.star;  // Пустая
                }
            }
        }

        private void SetUserId()
        {
            if (_comment.UserID != _currentUserId)
            {
                ProfileForm form = new ProfileForm((int)_comment.UserID, true, _parentForm);
                VisibilityHelper.ShowNewForm(this.FindForm(), form);
                this.ParentForm.Hide();
            }
            else
            {
                ProfileForm form = new ProfileForm(_currentUserId, true, _parentForm);
                VisibilityHelper.ShowNewForm(this.FindForm(), form);
                this.ParentForm.Hide();
            }
        }

        private void commentLabel_TextChanged(object sender, EventArgs e)
        {
            int labelWidth = commentLabel.Width;

            int preferredHeight = CalculateLabelHeight(commentLabel.Text, commentLabel.Font, labelWidth);

            commentLabel.Height = preferredHeight;

            commentLabel.PerformLayout();
        }

        private void likesButton_Click(object sender, EventArgs e)
        {
            ToggleLike();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetUserId();
        }
    }
}
