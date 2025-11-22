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
    public partial class UserCommentsControl : UserControl
    {
        private readonly Form _parentForm;
        private Reviews _comment;


        public UserCommentsControl(Form parentForm, Reviews reviews)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _comment = reviews;

            LoadCommentInfo();
        }

        private void LoadCommentInfo()
        {
            
        }
    }
}
