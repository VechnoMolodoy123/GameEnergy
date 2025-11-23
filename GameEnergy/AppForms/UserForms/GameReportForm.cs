using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Messages;
using GameEnergy.Classes.Validation;
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
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.AppForms.UserForms
{
    public partial class GameReportForm : Form
    {
        Games _game;
        private int _currentUserId;
        private bool _reportReasonIsEmpty = false;
        private bool _reportMessageIsEmpty = false;

        public GameReportForm(Games game, int currentUserId)
        {
            InitializeComponent();

            _game = game;
            _currentUserId = currentUserId;

            LoadGameInfo();
        }

        private void IsReportEmpty()
        {
            _reportReasonIsEmpty = reportReasonComboBox.SelectedIndex == 0;
            _reportMessageIsEmpty = string.IsNullOrWhiteSpace(reportMessageTextBox.Text);

            reportReasonComboBox.BorderColor = _reportReasonIsEmpty == true ? Color.Red : Color.FromArgb(251, 187, 67);
            reportMessageTextBox.BorderColor = _reportMessageIsEmpty == true ? Color.Red : Color.FromArgb(251, 187, 67);
        }

        private void SendReportToDatabase()
        {
            var gameReport = new GameReports
            {
                UserID = _currentUserId,
                GameID = _game.GameID,
                ReportCategoryID = reportReasonComboBox.SelectedIndex + 2,
                ReportMessage = reportMessageTextBox.Text,
                ReportDate = DateTime.Now
            };

            Program.context.GameReports.Add(gameReport);

            Program.context.SaveChanges();

            MessageHelper.ShowInformationMessage("Жалоба передана на рассмотрение!", "Жалоба успешно отправлена!");
        }

        private bool HasExistingReport()
        {
            return Program.context.GameReports.Any(report => report.UserID == _currentUserId && report.GameID == _game.GameID);
        }

        private void ProcessReportSubmission()
        {
            if (!_reportReasonIsEmpty && !_reportMessageIsEmpty)
            {
                if (HasExistingReport())
                {
                    MessageHelper.ShowErrorMessage("Вы уже отправляли жалобу на эту игру");
                    this.Close();
                }
                else
                {
                    SendReportToDatabase();
                    this.Close();
                }
            }
        }

        private void LoadGameInfo()
        {
            titleLabel.Text += _game.Title;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void sendReportButton_Click(object sender, EventArgs e)
        {
            IsReportEmpty();
            ProcessReportSubmission();
        }
    }
}
