using GameEnergy.Classes.Customization;
using GameEnergy.Classes.DataAccess;
using GameEnergy.Classes.Images.InstallingImages;
using GameEnergy.Classes.Images.StoreImages;
using GameEnergy.Classes.Messages;
using GameEnergy.Classes.Validation;
using GameEnergy.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameEnergy.AppForms.UserForms
{
    public partial class ProfileForm : Form
    {
        private int _currentUserId;
        private bool _needArrow;
        private Form _backForm;
        private Users _currentUser;
        private string _base64Avatar;
        private static readonly Regex _onlyEnglishChars = new Regex(@"^[A-Za-z\d\W_]+$");

        public ProfileForm(int currentUserId, bool needArrow = false, Form backForm = null)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _needArrow = needArrow;
            _backForm = backForm;
            _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(personalDataPanel, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            ImageLoader.LoadAvatarImageFromUserID(_currentUserId, avatarPictureBox);
            ImageLoader.LoadAvatarImage(userAvatarPictureBox);

            nameLabel.Text = _currentUser.Username;
            nameTextBox.Text = _currentUser.Username;
            mailTextBox.Text = _currentUser.Email;

            ShowBackArrow();
        }

        private void ShowBackArrow()
        {
            if (_needArrow)
            {
                arrowButton.Visible = true;
            }
        }

        private bool IsUserNameValid()
        {
            userNameLabel.ForeColor = nameTextBox.Text == "" || !_onlyEnglishChars.IsMatch(nameTextBox.Text) ? Color.Red : Color.White;

            return nameTextBox.Text == "" || !_onlyEnglishChars.IsMatch(nameTextBox.Text) ? false : true;
        }

        private void UpdateUserInfoLocation()
        {
            Control container = profilePanel;

            int avatarWidth = avatarPictureBox.Width;
            int avatarHeight = avatarPictureBox.Height;
            int labelWidth = nameLabel.Width;
            int labelHeight = nameLabel.Height;

            int centerX = container.ClientSize.Width / 2;

            avatarPictureBox.Location = new Point(centerX - avatarWidth / 2, 5);
            nameLabel.Location = new Point(centerX - labelWidth / 2, avatarPictureBox.Bottom + 5);
        }

        private void ProfileForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                navigationControl.LeftPanelWidth = 500;
                navigationControl.RightPanelWidth = 500;
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
            }

            navigationControl.UpdatePanelsWidth();
            UpdateUserInfoLocation();
        }

        private void ProfileForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void UserTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTabControl.SelectedIndex == 2)
            {
                Form form = new RegistrationOrAuthorizationForm();
                form.Show();
                this.Dispose();
                return;
            }

            SetFormStyle();
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            if (_backForm != null)
            {
                _backForm.StartPosition = FormStartPosition.Manual;
                _backForm.Location = this.Location;
                _backForm.WindowState = this.WindowState;
                _backForm.Show();
                this.Close();
            }
            else
            {
                MainForm form = new MainForm();
                VisibilityHelper.ShowNewForm(this, form);
                this.Hide();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsUserNameValid())
            {
                return;
            }

            string mail = mailTextBox.Text?.Trim();

            if (mail != _currentUser.Email)
            {
                if (!ValidationHelper.ValidateMailField(mail))
                {
                    return;
                }

                if (!ValidationHelper.ValidateNewMail(mailTextBox))
                {
                    return;
                }
            }

            if (!string.IsNullOrEmpty(oldPasswordTextBox.Text) || !string.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                if (!ValidationHelper.ValidationPasswordField(newPasswordTextBox))
                {
                    return;
                }

                if (!ValidationHelper.ValidationResetPassword(oldPasswordTextBox, newPasswordTextBox))
                {
                    return;
                }
            }

            bool changesMade = false;

            if (nameTextBox.Text != _currentUser.Username)
            {
                _currentUser.Username = nameTextBox.Text;
                changesMade = true;
            }

            if (!string.IsNullOrEmpty(_base64Avatar) && _base64Avatar != UserAvatarDataHelper.GetBase64ImageFromDatabase(_currentUserId))
            {
                _currentUser.Avatar = _base64Avatar;
                changesMade = true;
            }

            if (mail != _currentUser.Email)
            {
                _currentUser.Email = mail;
                changesMade = true;
            }

            if (changesMade)
            {
                Program.context.SaveChanges();
            }

            MessageHelper.ShowInformationMessage("Данные обновлены", "Успех");
        }

        private void userAvatarPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                dlg.Title = "Выберите новый аватар";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dlg.FileName;
                    _base64Avatar = CodingOrDecoding.ImageCoding(filePath);
                    ImageLoader.LoadAvatarImageFromString(_base64Avatar, userAvatarPictureBox);
                }
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            UpdateUserInfoLocation();
            EnableButtonLogic();
        }

        private void EnableButtonLogic()
        {
            if (_currentUserId != Program.CurrentUser.UserID)
            {
                while (UserTabControl.TabPages.Count > 1)
                {
                    UserTabControl.TabPages.RemoveAt(1);
                }
            }
        }
    }
}
