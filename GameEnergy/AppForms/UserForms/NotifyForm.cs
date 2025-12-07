using GameEnergy.Classes.Customization;
using GameEnergy.CustomControls;
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
    public partial class NotifyForm : Form
    {
        private int _currentUser = Program.CurrentUser.UserRoleID;

        public NotifyForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            CheckUserRole();
        }

        private void CheckUserRole()
        {
            if (_currentUser == 1)
            {
                topPanel.Height = 30;
                newNotifyButton.Visible = false;
                ShowUserNotify();
            }
            else
            {
                topPanel.Height = 76;
                newNotifyButton.Visible = true;
                ShowAdminNotify();
            }
        }

        private void OnNotifyControlDeleted(NotifyControl control)
        {
            notifyPanel.Controls.Remove(control);
            control.Dispose();
        }

        private void ShowAdminNotify()
        {
            
        }

        private void ShowUserNotify()
        {
            
        }

        private void newNotifyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
