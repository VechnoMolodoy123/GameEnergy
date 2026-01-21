namespace GameEnergy.AppForms.UserForms
{
    partial class RecoverPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPasswordForm));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.unvisiblePassword = new System.Windows.Forms.PictureBox();
            this.confirmPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.changePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).BeginInit();
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
            this.navigationPanel.TabIndex = 5;
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
            // visiblePassword
            // 
            this.visiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblePassword.Image = global::GameEnergy.Properties.Resources.visiblePussword;
            this.visiblePassword.Location = new System.Drawing.Point(252, 131);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(21, 18);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 21;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // unvisiblePassword
            // 
            this.unvisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unvisiblePassword.Image = global::GameEnergy.Properties.Resources.unVisiblePussword;
            this.unvisiblePassword.Location = new System.Drawing.Point(250, 129);
            this.unvisiblePassword.Name = "unvisiblePassword";
            this.unvisiblePassword.Size = new System.Drawing.Size(25, 22);
            this.unvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unvisiblePassword.TabIndex = 20;
            this.unvisiblePassword.TabStop = false;
            this.unvisiblePassword.Visible = false;
            this.unvisiblePassword.Click += new System.EventHandler(this.unvisiblePassword_Click);
            // 
            // confirmPasswordTextField
            // 
            this.confirmPasswordTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.confirmPasswordTextField.Depth = 0;
            this.confirmPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.confirmPasswordTextField.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextField.Hint = "Подтверждение пароля";
            this.confirmPasswordTextField.Location = new System.Drawing.Point(54, 136);
            this.confirmPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmPasswordTextField.Name = "confirmPasswordTextField";
            this.confirmPasswordTextField.PasswordChar = '*';
            this.confirmPasswordTextField.SelectedText = "";
            this.confirmPasswordTextField.SelectionLength = 0;
            this.confirmPasswordTextField.SelectionStart = 0;
            this.confirmPasswordTextField.Size = new System.Drawing.Size(190, 23);
            this.confirmPasswordTextField.TabIndex = 19;
            this.confirmPasswordTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordTextField.ForeColor = System.Drawing.Color.White;
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(54, 100);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(190, 23);
            this.passwordTextField.TabIndex = 18;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите новый пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Animated = true;
            this.changePasswordButton.BorderColor = System.Drawing.Color.Yellow;
            this.changePasswordButton.BorderRadius = 17;
            this.changePasswordButton.BorderThickness = 1;
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.changePasswordButton.IndicateFocus = true;
            this.changePasswordButton.Location = new System.Drawing.Point(86, 174);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.PressedColor = System.Drawing.Color.Yellow;
            this.changePasswordButton.Size = new System.Drawing.Size(131, 34);
            this.changePasswordButton.TabIndex = 23;
            this.changePasswordButton.Text = "СМЕНИТЬ ПАРОЛЬ";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(305, 220);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visiblePassword);
            this.Controls.Add(this.unvisiblePassword);
            this.Controls.Add(this.confirmPasswordTextField);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoverPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPasswordForm";
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
        private System.Windows.Forms.PictureBox visiblePassword;
        private System.Windows.Forms.PictureBox unvisiblePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmPasswordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button changePasswordButton;
    }
}