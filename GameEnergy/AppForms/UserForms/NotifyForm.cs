using GameEnergy.AppForms.AdminForms;
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
using System.Web.UI;
using System.Windows.Forms;

namespace GameEnergy.AppForms.UserForms
{
    public partial class NotifyForm : Form
    {
        Users _currentUser = Program.CurrentUser;
        private List<object> _currentNotifications;

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
            if (_currentUser.UserRoleID == 1)
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

        private void ShowUserNotify()
        {
            notifyPanel.Controls.Clear();

            var hiddenNotificationIds = Program.context.DeletedNotifications
                .Where(dn => dn.UserID == _currentUser.UserID)
                .Select(dn => dn.NotifyID)
                .ToList();

            var notifications = Program.context.SystemNotifications
                .Where(n => !hiddenNotificationIds.Contains(n.NotifyID))
                .OrderByDescending(n => n.NotifyDate)
                .ToList()
                .Cast<object>()
                .ToList();

            _currentNotifications = notifications.Cast<object>().ToList();

            foreach (SystemNotifications notification in notifications)
            {
                var userControl = new NotifyControl(notification);
                userControl.Margin = new Padding(0, 0, 0, 10);
                userControl.Deleted += OnNotifyControlDeleted;
                notifyPanel.Controls.Add(userControl);
            }
        }

        private void ShowAdminNotify()
        {
            notifyPanel.Controls.Clear();

            var notifications = Program.context.GameReports
                .OrderByDescending(n => n.ReportDate)
                .ToList()
                .Cast<object>()
                .ToList();

            _currentNotifications = notifications.Cast<object>().ToList();

            foreach (GameReports notification in notifications)
            {
                var userControl = new NotifyControl(notification);
                userControl.Margin = new Padding(0, 0, 0, 10);
                userControl.Deleted += OnNotifyControlDeleted;
                notifyPanel.Controls.Add(userControl);
            }
        }

        private void newNotifyButton_Click(object sender, EventArgs e)
        {
            Form form = new WriteNotifyForm();
            form.ShowDialog();
        }
    }
}
