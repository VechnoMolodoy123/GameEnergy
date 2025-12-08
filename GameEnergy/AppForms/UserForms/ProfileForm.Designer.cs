namespace GameEnergy.AppForms.UserForms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationControl = new GameEnergy.CustomControls.NavigationControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.UserTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.profile = new System.Windows.Forms.TabPage();
            this.profilePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userData = new System.Windows.Forms.TabPage();
            this.personalDataPanel = new System.Windows.Forms.Panel();
            this.userAvatarPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logOut = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arrowButton = new Guna.UI2.WinForms.Guna2Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.UserTabControl.SuspendLayout();
            this.profile.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.userData.SuspendLayout();
            this.personalDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            // navigationControl
            // 
            this.navigationControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.navigationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationControl.leftPanel = null;
            this.navigationControl.LeftPanelWidth = 0;
            this.navigationControl.Location = new System.Drawing.Point(0, 0);
            this.navigationControl.Margin = new System.Windows.Forms.Padding(6);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(726, 52);
            this.navigationControl.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.UserTabControl);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 4;
            // 
            // UserTabControl
            // 
            this.UserTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.UserTabControl.Controls.Add(this.profile);
            this.UserTabControl.Controls.Add(this.userData);
            this.UserTabControl.Controls.Add(this.logOut);
            this.UserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTabControl.ItemSize = new System.Drawing.Size(173, 40);
            this.UserTabControl.Location = new System.Drawing.Point(100, 45);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(526, 333);
            this.UserTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.UserTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(46)))));
            this.UserTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.UserTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.UserTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.UserTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.UserTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UserTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.UserTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.UserTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UserTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.UserTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.UserTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.UserTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.UserTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.UserTabControl.TabButtonSize = new System.Drawing.Size(173, 40);
            this.UserTabControl.TabIndex = 36;
            this.UserTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UserTabControl.SelectedIndexChanged += new System.EventHandler(this.UserTabControl_SelectedIndexChanged);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profile.Controls.Add(this.profilePanel);
            this.profile.Controls.Add(this.panel3);
            this.profile.Location = new System.Drawing.Point(177, 4);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(345, 325);
            this.profile.TabIndex = 0;
            this.profile.Text = "Профиль";
            // 
            // profilePanel
            // 
            this.profilePanel.BorderColor = System.Drawing.Color.Gray;
            this.profilePanel.BorderRadius = 10;
            this.profilePanel.BorderThickness = 1;
            this.profilePanel.Controls.Add(this.avatarPictureBox);
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePanel.FillColor = System.Drawing.Color.Black;
            this.profilePanel.Location = new System.Drawing.Point(38, 3);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(304, 114);
            this.profilePanel.TabIndex = 38;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.Black;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(122, 5);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 5;
            this.avatarPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(118, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 32);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "ИМЯ";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 319);
            this.panel3.TabIndex = 1;
            // 
            // userData
            // 
            this.userData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.userData.Controls.Add(this.personalDataPanel);
            this.userData.Controls.Add(this.panel4);
            this.userData.Controls.Add(this.orderPanel);
            this.userData.Location = new System.Drawing.Point(177, 4);
            this.userData.Name = "userData";
            this.userData.Padding = new System.Windows.Forms.Padding(3);
            this.userData.Size = new System.Drawing.Size(345, 325);
            this.userData.TabIndex = 1;
            this.userData.Text = "Личные данные";
            // 
            // personalDataPanel
            // 
            this.personalDataPanel.Controls.Add(this.userAvatarPictureBox);
            this.personalDataPanel.Controls.Add(this.saveButton);
            this.personalDataPanel.Controls.Add(this.newPasswordTextBox);
            this.personalDataPanel.Controls.Add(this.oldPasswordTextBox);
            this.personalDataPanel.Controls.Add(this.label4);
            this.personalDataPanel.Controls.Add(this.mailTextBox);
            this.personalDataPanel.Controls.Add(this.userEmailLabel);
            this.personalDataPanel.Controls.Add(this.nameTextBox);
            this.personalDataPanel.Controls.Add(this.userNameLabel);
            this.personalDataPanel.Controls.Add(this.label1);
            this.personalDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalDataPanel.Location = new System.Drawing.Point(38, 3);
            this.personalDataPanel.Name = "personalDataPanel";
            this.personalDataPanel.Size = new System.Drawing.Size(304, 319);
            this.personalDataPanel.TabIndex = 71;
            // 
            // userAvatarPictureBox
            // 
            this.userAvatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.userAvatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAvatarPictureBox.ImageRotate = 0F;
            this.userAvatarPictureBox.Location = new System.Drawing.Point(237, 3);
            this.userAvatarPictureBox.Name = "userAvatarPictureBox";
            this.userAvatarPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userAvatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.userAvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatarPictureBox.TabIndex = 73;
            this.userAvatarPictureBox.TabStop = false;
            this.userAvatarPictureBox.Click += new System.EventHandler(this.userAvatarPictureBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.BorderRadius = 8;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.HoverState.FillColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(6, 311);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 36);
            this.saveButton.TabIndex = 59;
            this.saveButton.Text = "СОХРАНИТЬ";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.newPasswordTextBox.BorderRadius = 10;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.newPasswordTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.newPasswordTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(6, 255);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.newPasswordTextBox.PlaceholderText = "Новый пароль";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.Size = new System.Drawing.Size(173, 36);
            this.newPasswordTextBox.TabIndex = 58;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.oldPasswordTextBox.BorderRadius = 10;
            this.oldPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPasswordTextBox.DefaultText = "";
            this.oldPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.oldPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.oldPasswordTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.oldPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.oldPasswordTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(6, 206);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.oldPasswordTextBox.PlaceholderText = "Текущий пароль";
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(173, 36);
            this.oldPasswordTextBox.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "СМЕНА ПАРОЛЯ";
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.mailTextBox.BorderRadius = 10;
            this.mailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailTextBox.DefaultText = "";
            this.mailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.mailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.mailTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.mailTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTextBox.ForeColor = System.Drawing.Color.White;
            this.mailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.mailTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.mailTextBox.Location = new System.Drawing.Point(6, 113);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.mailTextBox.PlaceholderText = "Почта";
            this.mailTextBox.SelectedText = "";
            this.mailTextBox.Size = new System.Drawing.Size(173, 36);
            this.mailTextBox.TabIndex = 53;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEmailLabel.ForeColor = System.Drawing.Color.White;
            this.userEmailLabel.Location = new System.Drawing.Point(3, 97);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(45, 13);
            this.userEmailLabel.TabIndex = 52;
            this.userEmailLabel.Text = "E-MAIL";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.nameTextBox.BorderRadius = 10;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.nameTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.nameTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.nameTextBox.Location = new System.Drawing.Point(6, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameTextBox.PlaceholderText = "Имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(173, 36);
            this.nameTextBox.TabIndex = 51;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(3, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(65, 13);
            this.userNameLabel.TabIndex = 50;
            this.userNameLabel.Text = "НИКНЕЙМ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЛИЧНЫЕ ДАННЫЕ";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 319);
            this.panel4.TabIndex = 69;
            // 
            // orderPanel
            // 
            this.orderPanel.AutoSize = true;
            this.orderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderPanel.Location = new System.Drawing.Point(3, 3);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(339, 0);
            this.orderPanel.TabIndex = 68;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.logOut.Location = new System.Drawing.Point(177, 4);
            this.logOut.Name = "logOut";
            this.logOut.Padding = new System.Windows.Forms.Padding(3);
            this.logOut.Size = new System.Drawing.Size(345, 325);
            this.logOut.TabIndex = 2;
            this.logOut.Text = "Выход";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arrowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 45);
            this.panel1.TabIndex = 31;
            // 
            // arrowButton
            // 
            this.arrowButton.Animated = true;
            this.arrowButton.BorderRadius = 8;
            this.arrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.arrowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.arrowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.arrowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.arrowButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.arrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrowButton.ForeColor = System.Drawing.Color.Black;
            this.arrowButton.HoverState.FillColor = System.Drawing.Color.White;
            this.arrowButton.Location = new System.Drawing.Point(0, 8);
            this.arrowButton.Name = "arrowButton";
            this.arrowButton.Size = new System.Drawing.Size(129, 30);
            this.arrowButton.TabIndex = 16;
            this.arrowButton.Text = "Вернуться назад";
            this.arrowButton.Visible = false;
            this.arrowButton.Click += new System.EventHandler(this.arrowButton_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(626, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 378);
            this.rightPanel.TabIndex = 30;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 378);
            this.leftPanel.TabIndex = 29;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.SizeChanged += new System.EventHandler(this.ProfileForm_SizeChanged);
            this.Resize += new System.EventHandler(this.ProfileForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.UserTabControl.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.userData.ResumeLayout(false);
            this.userData.PerformLayout();
            this.personalDataPanel.ResumeLayout(false);
            this.personalDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Button arrowButton;
        private Guna.UI2.WinForms.Guna2TabControl UserTabControl;
        private System.Windows.Forms.TabPage profile;
        private Guna.UI2.WinForms.Guna2Panel profilePanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatarPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage userData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
        private System.Windows.Forms.TabPage logOut;
        private System.Windows.Forms.Panel personalDataPanel;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox mailTextBox;
        private System.Windows.Forms.Label userEmailLabel;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userAvatarPictureBox;
    }
}