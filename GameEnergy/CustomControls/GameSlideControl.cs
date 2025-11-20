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

namespace GameEnergy.CustomControls
{
    public partial class GameSlideControl : UserControl
    {
        private int _gameID;
        private string _titleOverride;

        public GameSlideControl(int gameID, string titleOverride)
        {
            InitializeComponent();

            _gameID = gameID;
            _titleOverride = titleOverride;

            //LoadGameInfo();
        }


    }
}
