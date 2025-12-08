using GameEnergy.Classes.Customization;
using GameEnergy.CustomControls;
using GameEnergy.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GameEnergy.AppForms.UserForms
{
    public partial class LibraryForm : Form
    {
        int _currentUserId = Program.CurrentUser.UserID;

        public LibraryForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            gameCountLabel.Text = Program.context.UserLibrary.Where(ul => ul.UserID == _currentUserId).Count().ToString();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            var games = Program.context.UserLibrary.Where(ul => ul.UserID == _currentUserId).OrderByDescending(ul => ul.AddedDate)
                .Join(Program.context.Games, ul => ul.GameID, g => g.GameID, (ul, g) => g).ToList();

            foreach (Games game in games)
            {
                var gamesControl = new MainGameControl(game);
                gamesControl.Margin = new Padding(10);
                gamesControl.GameClicked += GameControl_GameClicked;
                gamesPanel.Controls.Add(gamesControl);
            }
        }

        private void GameControl_GameClicked(object sender, Games game)
        {
            var form = new GameInfoForm(game);
            VisibilityHelper.ShowNewForm(this, form);
            this.Hide();
        }

        private void LibraryForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void LibraryForm_SizeChanged(object sender, EventArgs e)
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
        }
    }
}
