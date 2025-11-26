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
    public partial class CartControl : UserControl
    {
        CartItems _item;

        public CartControl(CartItems item)
        {
            InitializeComponent();

            _item = item;

            LoadItemInfo();
        }

        private void LoadItemInfo()
        {
            throw new NotImplementedException();
        }
    }
}
