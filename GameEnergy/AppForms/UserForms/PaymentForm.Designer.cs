namespace GameEnergy.AppForms.UserForms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FormRounded
            // 
            this.FormRounded.BorderRadius = 11;
            this.FormRounded.ContainerControl = this;
            this.FormRounded.DockIndicatorTransparencyValue = 0.6D;
            this.FormRounded.DragForm = false;
            this.FormRounded.ResizeForm = false;
            this.FormRounded.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 7;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.orderNumberLabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(299, 149);
            this.guna2Panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Оплата прошла успешно";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.orderNumberLabel.Location = new System.Drawing.Point(207, 34);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(22, 24);
            this.orderNumberLabel.TabIndex = 15;
            this.orderNumberLabel.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ваш заказ №";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::GameEnergy.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(265, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 13;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeButton;
    }
}