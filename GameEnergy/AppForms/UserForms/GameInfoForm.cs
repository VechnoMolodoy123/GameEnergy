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
    public partial class GameInfoForm : Form
    {
        Games _game;

        public GameInfoForm(Games game)
        {
            InitializeComponent();

            _game = game;
        }
    }
}
