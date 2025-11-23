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

namespace GameEnergy.AppForms.AdminForms
{
    public partial class CreateOrUpdateGameForm : Form
    {
        public event Action GameUpdated;
        private string _selectedImagePath;
        private Games _editingGame;

        public CreateOrUpdateGameForm(Games game = null)
        {
            InitializeComponent();

            _editingGame = game;

            LoadGameInfo();
        }

        private void LoadGameInfo()
        {
            
        }
    }
}
