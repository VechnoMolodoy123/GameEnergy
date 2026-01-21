using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Validation;
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

namespace GameEnergy.AppForms.UserForms
{
    public partial class RecoverPasswordForm : Form
    {
        private ValidationHelper _validationHelper;
        private string _userEmail;

        public RecoverPasswordForm(ValidationHelper validationHelper, string userEmail)
        {
            InitializeComponent();

            _validationHelper = validationHelper;
            _userEmail = userEmail;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            var passwordTextBox = (TextBox)passwordTextField.Controls[0];
            var confirmPasswordTextBox = (TextBox)confirmPasswordTextField.Controls[0];


            passwordTextBox.MaxLength = 32;
            confirmPasswordTextBox.MaxLength = 32;
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

        private async void changePasswordButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { passwordTextField, confirmPasswordTextField };

            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                if (ValidationHelper.ValidationPasswordFields(passwordTextField, confirmPasswordTextField))
                {
                    if (_validationHelper.ValidationPasswordRecovery(_userEmail, passwordTextField, confirmPasswordTextField))
                    {
                        Form form = new RegistrationOrAuthorizationForm();
                        form.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm();
            form.Show();
            this.Hide();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
