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
    public partial class PaymentForm : Form
    {
        public PaymentForm(int orderNumber)
        {
            InitializeComponent();

            orderNumberLabel.Text = orderNumber.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
