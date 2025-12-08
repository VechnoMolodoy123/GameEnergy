using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Messages;
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

namespace GameEnergy.AppForms.AdminForms
{
    public partial class WriteNotifyForm : Form
    {
        public WriteNotifyForm()
        {
            InitializeComponent();
        }

        private void ValidateFields()
        {
            bool titleEmpty = string.IsNullOrWhiteSpace(titleTextBox.Text);
            bool descEmpty = string.IsNullOrWhiteSpace(descriptionTextBox.Text);

            if (titleEmpty || descEmpty)
            {
                titleTextBox.BorderColor = titleEmpty ? Color.Red : Color.FromArgb(251, 187, 67);
                descriptionTextBox.BorderColor = descEmpty ? Color.Red : Color.FromArgb(251, 187, 67);
            }
            else
                SendNotifyToDatabase();
        }

        private void SendNotifyToDatabase()
        {
            try
            {
                var systemNotify = new SystemNotifications
                {
                    NotifyTitle = titleTextBox.Text,
                    NotifyMessage = descriptionTextBox.Text,
                    NotifyDate = DateTime.Now
                };

                Program.context.SystemNotifications.Add(systemNotify);
                Program.context.SaveChanges();

                MessageHelper.ShowInformationMessage("Сообщение успешно отправлено", "Успех");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage($"Не удалось отправить уведомление:\n{ex.Message}");
            }
        }

        private void sendNotifyButton_Click(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
