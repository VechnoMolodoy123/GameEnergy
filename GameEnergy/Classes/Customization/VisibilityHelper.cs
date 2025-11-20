using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy.Classes.Customization
{
    internal class VisibilityHelper
    {
        public static void ShowPassword(MaterialSingleLineTextField[] passwordFields, PictureBox showButton, PictureBox hideButton)
        {
            showButton.Visible = false;
            hideButton.Visible = true;

            foreach (var field in passwordFields)
            {
                field.PasswordChar = '\0';
            }
        }

        public static void HidePassword(MaterialSingleLineTextField[] passwordFields, PictureBox showButton, PictureBox hideButton)
        {
            hideButton.Visible = false;
            showButton.Visible = true;

            foreach (var field in passwordFields)
            {
                field.PasswordChar = '*';
            }
        }

        public static void ShowNewForm(Form form, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = form.Location;
            newForm.WindowState = form.WindowState;
            newForm.Show();
        }
    }
}
