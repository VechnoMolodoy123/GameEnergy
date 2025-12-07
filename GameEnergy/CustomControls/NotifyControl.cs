using GameEnergy.AppForms.UserForms;
using GameEnergy.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameEnergy.CustomControls
{
    public partial class NotifyControl : UserControl
    {
        private object _notificationData;
        Users _currentUser;
        Games _game;
        public object NotificationData => _notificationData;
        public event Action<NotifyControl> Deleted;

        public NotifyControl(object notificationData)
        {
            InitializeComponent();

            _notificationData = notificationData;

            LoadNotifyInfo();
        }

        private void DefaultStyle()
        {
            senderLabel.Visible = true;
            nameLabel.Visible = true;
            gameLabel.Visible = true;
        }

        private void NewStyle()
        {
            senderLabel.Visible = false;
            nameLabel.Visible = false;
            gameLabel.Visible = false;
        }

        private void LoadNotifyInfo()
        {
            DefaultStyle();

            if (_notificationData is SystemNotifications systemNotification)
            {
                NewStyle();
                var newBookReport = Program.context.SystemNotifications.AsNoTracking()
                    .FirstOrDefault(n => n.NotifyID == systemNotification.NotifyID);
                titleLabel.Text = systemNotification.NotifyTitle;
                messageLabel.Text = systemNotification.NotifyMessage;
                dateLabel.Text = systemNotification.NotifyDate
                    .ToString("d MMMM yyyy 'в' HH:mm", new System.Globalization.CultureInfo("ru-RU"));
                return;
            }
            else if (_notificationData is GameReports gameReport)
            {
                var newGameReport = Program.context.GameReports.AsNoTracking()
                    .FirstOrDefault(g => g.GameReportID == gameReport.GameReportID);
                _currentUser = newGameReport.Users;
                _game = newGameReport.Games;
                nameLabel.Text = newGameReport.Users.Username;
                titleLabel.Text = "Жалоба на игру:";
                gameLabel.Text = newGameReport.Games.Title;
                messageLabel.Text = newGameReport.ReportMessage;
                dateLabel.Text = newGameReport.ReportDate
                    .ToString("d MMMM yyyy 'в' HH:mm", new System.Globalization.CultureInfo("ru-RU"));
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            Form form = new ProfileForm(_currentUser.UserID);
            form.ShowDialog();
        }

        private void gameLabel_Click(object sender, EventArgs e)
        {
            Form form = new GameInfoForm(_game);
            form.ShowDialog();
        }

        private void copyMailButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_currentUser.Email);

            copyMailButton.Text = "Почта скопирована";
            copyMailButton.ForeColor = Color.Green;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, args) =>
            {
                copyMailButton.Text = "Скопировать почту";
                copyMailButton.ForeColor = Color.Black;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_notificationData is SystemNotifications systemNotification)
            {
                if (!Program.context.DeletedNotifications
                    .Any(dn => dn.NotifyID == systemNotification.NotifyID && dn.UserID == _currentUser.UserID))
                {
                    Program.context.DeletedNotifications.Add(new DeletedNotifications
                    {
                        NotifyID = systemNotification.NotifyID,
                        UserID = _currentUser.UserID,
                        DeletedDate = DateTime.Now
                    });
                }
            }
            else if (_notificationData is GameReports gameReport)
            {
                var entry = Program.context.GameReports.Find(gameReport.GameReportID);
                if (entry != null)
                {
                    Program.context.GameReports.Remove(entry);
                    Program.context.SaveChanges();
                }
            }

            Deleted?.Invoke(this);
        }
    }
}
