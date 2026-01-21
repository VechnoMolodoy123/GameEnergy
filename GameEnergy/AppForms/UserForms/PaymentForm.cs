using System;
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
