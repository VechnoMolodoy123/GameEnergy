using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Images.InstallingImages;
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
    public partial class ProfileForm : Form
    {
        private int _currentUserId;
        private bool _needArrow;
        private Form _backForm;
        private Users _currentUser;

        public ProfileForm(int currentUserId, bool needArrow = false, Form backForm = null)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _needArrow = needArrow;
            _backForm = backForm;
            _currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == _currentUserId);

            SetFormStyle();
        }

        private void SetFormStyle()
        {

        }
    }
}
