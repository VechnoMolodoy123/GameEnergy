namespace GameEnergy
{
    partial class RegistrationOrAuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationOrAuthorizationForm));
            this.registrationOrAuthorizationTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.Authorization = new System.Windows.Forms.TabPage();
            this.logInButton = new Guna.UI2.WinForms.Guna2Button();
            this.logInVisiblePassword = new System.Windows.Forms.PictureBox();
            this.logInUnvisiblePassword = new System.Windows.Forms.PictureBox();
            this.fogetPasswordLabel = new System.Windows.Forms.Label();
            this.logInPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.logInNameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Registration = new System.Windows.Forms.TabPage();
            this.unvisiblePassword = new System.Windows.Forms.PictureBox();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.registerButton = new Guna.UI2.WinForms.Guna2Button();
            this.mailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.confirmPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.registrationOrAuthorizationTabControl.SuspendLayout();
            this.Authorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logInVisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInUnvisiblePassword)).BeginInit();
            this.Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationOrAuthorizationTabControl
            // 
            this.registrationOrAuthorizationTabControl.Controls.Add(this.Authorization);
            this.registrationOrAuthorizationTabControl.Controls.Add(this.Registration);
            this.registrationOrAuthorizationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationOrAuthorizationTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationOrAuthorizationTabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.registrationOrAuthorizationTabControl.Location = new System.Drawing.Point(0, 30);
            this.registrationOrAuthorizationTabControl.Name = "registrationOrAuthorizationTabControl";
            this.registrationOrAuthorizationTabControl.SelectedIndex = 0;
            this.registrationOrAuthorizationTabControl.Size = new System.Drawing.Size(305, 301);
            this.registrationOrAuthorizationTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.registrationOrAuthorizationTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.registrationOrAuthorizationTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.registrationOrAuthorizationTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.registrationOrAuthorizationTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.registrationOrAuthorizationTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.registrationOrAuthorizationTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.registrationOrAuthorizationTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.registrationOrAuthorizationTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.registrationOrAuthorizationTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.registrationOrAuthorizationTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.registrationOrAuthorizationTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.registrationOrAuthorizationTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.registrationOrAuthorizationTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.registrationOrAuthorizationTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.registrationOrAuthorizationTabControl.TabButtonSize = new System.Drawing.Size(150, 40);
            this.registrationOrAuthorizationTabControl.TabIndex = 4;
            this.registrationOrAuthorizationTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.registrationOrAuthorizationTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // Authorization
            // 
            this.Authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Authorization.Controls.Add(this.logInButton);
            this.Authorization.Controls.Add(this.logInVisiblePassword);
            this.Authorization.Controls.Add(this.logInUnvisiblePassword);
            this.Authorization.Controls.Add(this.fogetPasswordLabel);
            this.Authorization.Controls.Add(this.logInPasswordTextField);
            this.Authorization.Controls.Add(this.logInNameTextField);
            this.Authorization.Location = new System.Drawing.Point(4, 44);
            this.Authorization.Name = "Authorization";
            this.Authorization.Padding = new System.Windows.Forms.Padding(3);
            this.Authorization.Size = new System.Drawing.Size(297, 253);
            this.Authorization.TabIndex = 0;
            this.Authorization.Text = "Вход";
            // 
            // logInButton
            // 
            this.logInButton.Animated = true;
            this.logInButton.BorderColor = System.Drawing.Color.Yellow;
            this.logInButton.BorderRadius = 17;
            this.logInButton.BorderThickness = 1;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.ForeColor = System.Drawing.Color.Black;
            this.logInButton.IndicateFocus = true;
            this.logInButton.Location = new System.Drawing.Point(88, 172);
            this.logInButton.Name = "logInButton";
            this.logInButton.PressedColor = System.Drawing.Color.Yellow;
            this.logInButton.Size = new System.Drawing.Size(118, 34);
            this.logInButton.TabIndex = 12;
            this.logInButton.Text = "ВОЙТИ";
            // 
            // logInVisiblePassword
            // 
            this.logInVisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInVisiblePassword.Image = global::GameEnergy.Properties.Resources.visiblePussword;
            this.logInVisiblePassword.Location = new System.Drawing.Point(233, 95);
            this.logInVisiblePassword.Name = "logInVisiblePassword";
            this.logInVisiblePassword.Size = new System.Drawing.Size(25, 22);
            this.logInVisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logInVisiblePassword.TabIndex = 15;
            this.logInVisiblePassword.TabStop = false;
            // 
            // logInUnvisiblePassword
            // 
            this.logInUnvisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInUnvisiblePassword.Image = global::GameEnergy.Properties.Resources.unVisiblePussword;
            this.logInUnvisiblePassword.Location = new System.Drawing.Point(233, 95);
            this.logInUnvisiblePassword.Name = "logInUnvisiblePassword";
            this.logInUnvisiblePassword.Size = new System.Drawing.Size(25, 22);
            this.logInUnvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logInUnvisiblePassword.TabIndex = 14;
            this.logInUnvisiblePassword.TabStop = false;
            this.logInUnvisiblePassword.Visible = false;
            // 
            // fogetPasswordLabel
            // 
            this.fogetPasswordLabel.AutoSize = true;
            this.fogetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fogetPasswordLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fogetPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.fogetPasswordLabel.Location = new System.Drawing.Point(86, 142);
            this.fogetPasswordLabel.Name = "fogetPasswordLabel";
            this.fogetPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.fogetPasswordLabel.TabIndex = 13;
            this.fogetPasswordLabel.Text = "Забыли пароль?";
            // 
            // logInPasswordTextField
            // 
            this.logInPasswordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.logInPasswordTextField.Depth = 0;
            this.logInPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInPasswordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logInPasswordTextField.Hint = "Пароль";
            this.logInPasswordTextField.Location = new System.Drawing.Point(37, 94);
            this.logInPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInPasswordTextField.Name = "logInPasswordTextField";
            this.logInPasswordTextField.PasswordChar = '*';
            this.logInPasswordTextField.SelectedText = "";
            this.logInPasswordTextField.SelectionLength = 0;
            this.logInPasswordTextField.SelectionStart = 0;
            this.logInPasswordTextField.Size = new System.Drawing.Size(190, 23);
            this.logInPasswordTextField.TabIndex = 11;
            this.logInPasswordTextField.UseSystemPasswordChar = false;
            // 
            // logInNameTextField
            // 
            this.logInNameTextField.BackColor = System.Drawing.SystemColors.Control;
            this.logInNameTextField.Depth = 0;
            this.logInNameTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInNameTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logInNameTextField.Hint = "Логин или почта";
            this.logInNameTextField.Location = new System.Drawing.Point(37, 51);
            this.logInNameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInNameTextField.Name = "logInNameTextField";
            this.logInNameTextField.PasswordChar = '\0';
            this.logInNameTextField.SelectedText = "";
            this.logInNameTextField.SelectionLength = 0;
            this.logInNameTextField.SelectionStart = 0;
            this.logInNameTextField.Size = new System.Drawing.Size(221, 23);
            this.logInNameTextField.TabIndex = 10;
            this.logInNameTextField.UseSystemPasswordChar = false;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Registration.Controls.Add(this.unvisiblePassword);
            this.Registration.Controls.Add(this.visiblePassword);
            this.Registration.Controls.Add(this.registerButton);
            this.Registration.Controls.Add(this.mailTextField);
            this.Registration.Controls.Add(this.confirmPasswordTextField);
            this.Registration.Controls.Add(this.passwordTextField);
            this.Registration.Controls.Add(this.nameTextField);
            this.Registration.Location = new System.Drawing.Point(4, 44);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(297, 253);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Регистрация";
            // 
            // unvisiblePassword
            // 
            this.unvisiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unvisiblePassword.Image = global::GameEnergy.Properties.Resources.visiblePussword;
            this.unvisiblePassword.Location = new System.Drawing.Point(233, 122);
            this.unvisiblePassword.Name = "unvisiblePassword";
            this.unvisiblePassword.Size = new System.Drawing.Size(25, 22);
            this.unvisiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unvisiblePassword.TabIndex = 17;
            this.unvisiblePassword.TabStop = false;
            // 
            // visiblePassword
            // 
            this.visiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblePassword.Image = global::GameEnergy.Properties.Resources.unVisiblePussword;
            this.visiblePassword.Location = new System.Drawing.Point(233, 122);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(25, 22);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 16;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Animated = true;
            this.registerButton.BorderColor = System.Drawing.Color.Yellow;
            this.registerButton.BorderRadius = 17;
            this.registerButton.BorderThickness = 1;
            this.registerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.IndicateFocus = true;
            this.registerButton.Location = new System.Drawing.Point(54, 184);
            this.registerButton.Name = "registerButton";
            this.registerButton.PressedColor = System.Drawing.Color.Yellow;
            this.registerButton.Size = new System.Drawing.Size(184, 34);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            // 
            // mailTextField
            // 
            this.mailTextField.BackColor = System.Drawing.SystemColors.Control;
            this.mailTextField.Depth = 0;
            this.mailTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mailTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mailTextField.Hint = "Почта";
            this.mailTextField.Location = new System.Drawing.Point(37, 70);
            this.mailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.mailTextField.Name = "mailTextField";
            this.mailTextField.PasswordChar = '\0';
            this.mailTextField.SelectedText = "";
            this.mailTextField.SelectionLength = 0;
            this.mailTextField.SelectionStart = 0;
            this.mailTextField.Size = new System.Drawing.Size(223, 23);
            this.mailTextField.TabIndex = 8;
            this.mailTextField.UseSystemPasswordChar = false;
            // 
            // confirmPasswordTextField
            // 
            this.confirmPasswordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPasswordTextField.Depth = 0;
            this.confirmPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.confirmPasswordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPasswordTextField.Hint = "Подтверждение пароля";
            this.confirmPasswordTextField.Location = new System.Drawing.Point(37, 141);
            this.confirmPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmPasswordTextField.Name = "confirmPasswordTextField";
            this.confirmPasswordTextField.PasswordChar = '*';
            this.confirmPasswordTextField.SelectedText = "";
            this.confirmPasswordTextField.SelectionLength = 0;
            this.confirmPasswordTextField.SelectionStart = 0;
            this.confirmPasswordTextField.Size = new System.Drawing.Size(190, 23);
            this.confirmPasswordTextField.TabIndex = 10;
            this.confirmPasswordTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextField.Hint = "Пароль";
            this.passwordTextField.Location = new System.Drawing.Point(37, 105);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(190, 23);
            this.passwordTextField.TabIndex = 9;
            this.passwordTextField.UseSystemPasswordChar = false;
            // 
            // nameTextField
            // 
            this.nameTextField.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextField.Depth = 0;
            this.nameTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nameTextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextField.Hint = "Логин";
            this.nameTextField.Location = new System.Drawing.Point(37, 35);
            this.nameTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.PasswordChar = '\0';
            this.nameTextField.SelectedText = "";
            this.nameTextField.SelectionLength = 0;
            this.nameTextField.SelectionStart = 0;
            this.nameTextField.Size = new System.Drawing.Size(223, 23);
            this.nameTextField.TabIndex = 7;
            this.nameTextField.UseSystemPasswordChar = false;
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
            this.navigationPanel.TabIndex = 3;
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
            // 
            // line
            // 
            this.line.BorderRadius = 1;
            this.line.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.line.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.line.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.line.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(0, 26);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(305, 4);
            this.line.TabIndex = 5;
            // 
            // RegistrationOrAuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(305, 331);
            this.Controls.Add(this.registrationOrAuthorizationTabControl);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrationOrAuthorizationForm";
            this.Text = "Регистрация/Авторизация";
            this.registrationOrAuthorizationTabControl.ResumeLayout(false);
            this.Authorization.ResumeLayout(false);
            this.Authorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logInVisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInUnvisiblePassword)).EndInit();
            this.Registration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unvisiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl registrationOrAuthorizationTabControl;
        private System.Windows.Forms.TabPage Authorization;
        private Guna.UI2.WinForms.Guna2Button logInButton;
        private System.Windows.Forms.PictureBox logInVisiblePassword;
        private System.Windows.Forms.PictureBox logInUnvisiblePassword;
        private System.Windows.Forms.Label fogetPasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField logInPasswordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField logInNameTextField;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.PictureBox unvisiblePassword;
        private System.Windows.Forms.PictureBox visiblePassword;
        private Guna.UI2.WinForms.Guna2Button registerButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField mailTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmPasswordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextField;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
    }
}

