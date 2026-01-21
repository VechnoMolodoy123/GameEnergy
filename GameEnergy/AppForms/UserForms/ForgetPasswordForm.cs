using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Validation;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GameEnergy.AppForms.UserForms
{
    public partial class ForgetPasswordForm : Form
    {
        private ValidationHelper _validationHelper;

        public ForgetPasswordForm()
        {
            InitializeComponent();

            _validationHelper = new ValidationHelper();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            var mailTextBox = (TextBox)mailTextField.Controls[0];
            var codeTextBox = (TextBox)verificationCodeTextField.Controls[0];

            mailTextBox.MaxLength = 50;
            codeTextBox.MaxLength = 6;
        }

        private async void sendCodeButton_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] fields = { mailTextField };

            if (await ValidationHelper.ValidateFieldIsEmpty(fields))
            {
                var result = await _validationHelper.ValidationForgetPassword(mailTextField, verificationCodeTextField, ResendVerificationCodeLabel, timerLabel);

                if (result.success)
                {
                    Form form = new RecoverPasswordForm(_validationHelper, result.email);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form form = new RegistrationOrAuthorizationForm();
            form.Show();
            this.Hide();
            ValidationHelper._isCodeSent = false;
        }

        private async void ResendVerificationCodeLabel_Click(object sender, EventArgs e)
        {
            await ValidationHelper.ResendConfirmationCode(mailTextField, timerLabel, ResendVerificationCodeLabel);
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
