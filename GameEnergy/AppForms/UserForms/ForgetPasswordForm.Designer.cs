namespace GameEnergy.AppForms.UserForms
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.mailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sendCodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.confirmationCodeTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 20;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 0.4D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.closeButton);
            this.navigationPanel.Controls.Add(this.collapseButton);
            this.navigationPanel.Controls.Add(this.line);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(305, 30);
            this.navigationPanel.TabIndex = 4;
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Image = global::GameEnergy.Properties.Resources.close;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(275, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 20;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.collapseButton.Image = global::GameEnergy.Properties.Resources.collapse;
            this.collapseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.collapseButton.Location = new System.Drawing.Point(251, 6);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(18, 18);
            this.collapseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapseButton.TabIndex = 21;
            this.collapseButton.TabStop = false;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.BorderRadius = 1;
            this.line.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.Enabled = false;
            this.line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(0, 27);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(305, 3);
            this.line.TabIndex = 5;
            // 
            // mailTextField
            // 
            this.mailTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mailTextField.Depth = 0;
            this.mailTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTextField.ForeColor = System.Drawing.Color.White;
            this.mailTextField.Hint = "Введите почту, на нее придет код";
            this.mailTextField.Location = new System.Drawing.Point(31, 71);
            this.mailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailTextField.Name = "mailTextField";
            this.mailTextField.PasswordChar = '\0';
            this.mailTextField.SelectedText = "";
            this.mailTextField.SelectionLength = 0;
            this.mailTextField.SelectionStart = 0;
            this.mailTextField.Size = new System.Drawing.Size(245, 23);
            this.mailTextField.TabIndex = 11;
            this.mailTextField.UseSystemPasswordChar = false;
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.Animated = true;
            this.sendCodeButton.BorderColor = System.Drawing.Color.Yellow;
            this.sendCodeButton.BorderRadius = 17;
            this.sendCodeButton.BorderThickness = 1;
            this.sendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCodeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendCodeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendCodeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendCodeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendCodeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sendCodeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendCodeButton.ForeColor = System.Drawing.Color.Black;
            this.sendCodeButton.IndicateFocus = true;
            this.sendCodeButton.Location = new System.Drawing.Point(81, 158);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.PressedColor = System.Drawing.Color.Yellow;
            this.sendCodeButton.Size = new System.Drawing.Size(138, 34);
            this.sendCodeButton.TabIndex = 13;
            this.sendCodeButton.Text = "ОТПРАВИТЬ КОД";
            // 
            // confirmationCodeTextField
            // 
            this.confirmationCodeTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.confirmationCodeTextField.Depth = 0;
            this.confirmationCodeTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmationCodeTextField.ForeColor = System.Drawing.Color.White;
            this.confirmationCodeTextField.Hint = "Код подтверждения";
            this.confirmationCodeTextField.Location = new System.Drawing.Point(31, 111);
            this.confirmationCodeTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmationCodeTextField.Name = "confirmationCodeTextField";
            this.confirmationCodeTextField.PasswordChar = '\0';
            this.confirmationCodeTextField.SelectedText = "";
            this.confirmationCodeTextField.SelectionLength = 0;
            this.confirmationCodeTextField.SelectionStart = 0;
            this.confirmationCodeTextField.Size = new System.Drawing.Size(245, 23);
            this.confirmationCodeTextField.TabIndex = 14;
            this.confirmationCodeTextField.UseSystemPasswordChar = false;
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(305, 220);
            this.Controls.Add(this.confirmationCodeTextField);
            this.Controls.Add(this.sendCodeButton);
            this.Controls.Add(this.mailTextField);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailTextField;
        private Guna.UI2.WinForms.Guna2Button sendCodeButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmationCodeTextField;
    }
}