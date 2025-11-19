using GameEnergy.AppForms.UserForms;
using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Customization;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy
{
    public partial class RegistrationOrAuthorizationForm : Form
    {
        public RegistrationOrAuthorizationForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            var logInNameTextBox = (TextBox)logInNameTextField.Controls[0];
            var logInPasswordTextBox = (TextBox)logInPasswordTextField.Controls[0];
            var nameTextBox = (TextBox)nameTextField.Controls[0];
            var mailTextBox = (TextBox)mailTextField.Controls[0];
            var passwordTextBox = (TextBox)passwordTextField.Controls[0];
            var confirmPasswordTextBox = (TextBox)confirmPasswordTextField.Controls[0];

            nameTextBox.MaxLength = 20;
            mailTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 32;
            confirmPasswordTextBox.MaxLength = 32;
        }

        private void fogetPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm();
            form.Show();
            this.Hide();
        }

        private void logInVisiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { logInPasswordTextField };
            VisibilityHelper.ShowPassword(passwordFields, logInVisiblePassword, logInUnvisiblePassword);
        }

        private void logInUnvisiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { logInPasswordTextField };
            VisibilityHelper.HidePassword(passwordFields, logInVisiblePassword, logInUnvisiblePassword);
        }

        private void visiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField, confirmPasswordTextField };
            VisibilityHelper.ShowPassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private void unvisiblePassword_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] passwordFields = { passwordTextField, confirmPasswordTextField };
            VisibilityHelper.HidePassword(passwordFields, visiblePassword, unvisiblePassword);
        }

        private async void logInButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            registrationOrAuthorizationTabControl.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }
    }
}
