namespace GameEnergy.CustomControls
{
    partial class NavigationControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.delimiter2 = new System.Windows.Forms.Panel();
            this.catalogButton = new Guna.UI2.WinForms.Guna2Button();
            this.delimiter1 = new System.Windows.Forms.Panel();
            this.bottomNavigationPanel = new System.Windows.Forms.Panel();
            this.topNavigationPanel = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.maximizeButton = new System.Windows.Forms.PictureBox();
            this.restoreButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.notifyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.cartNotifiPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationsButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.delimiter3 = new System.Windows.Forms.Panel();
            this.profileButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.delimiter5 = new System.Windows.Forms.Panel();
            this.libraryButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.delimiter4 = new System.Windows.Forms.Panel();
            this.cartButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.topRightPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
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
            this.line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line.Enabled = false;
            this.line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.line.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(0, 49);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(726, 3);
            this.line.TabIndex = 6;
            this.line.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(100, 49);
            this.topLeftPanel.TabIndex = 57;
            this.topLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topRightPanel
            // 
            this.topRightPanel.Controls.Add(this.closeButton);
            this.topRightPanel.Controls.Add(this.maximizeButton);
            this.topRightPanel.Controls.Add(this.restoreButton);
            this.topRightPanel.Controls.Add(this.minimizeButton);
            this.topRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.topRightPanel.Location = new System.Drawing.Point(626, 0);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(100, 49);
            this.topRightPanel.TabIndex = 58;
            this.topRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.cartNotifiPanel);
            this.navigationPanel.Controls.Add(this.notifyPanel);
            this.navigationPanel.Controls.Add(this.searchButton);
            this.navigationPanel.Controls.Add(this.panel1);
            this.navigationPanel.Controls.Add(this.notificationsButton);
            this.navigationPanel.Controls.Add(this.delimiter3);
            this.navigationPanel.Controls.Add(this.profileButton);
            this.navigationPanel.Controls.Add(this.delimiter5);
            this.navigationPanel.Controls.Add(this.libraryButton);
            this.navigationPanel.Controls.Add(this.delimiter4);
            this.navigationPanel.Controls.Add(this.cartButton);
            this.navigationPanel.Controls.Add(this.panel16);
            this.navigationPanel.Controls.Add(this.bottomNavigationPanel);
            this.navigationPanel.Controls.Add(this.topNavigationPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(100, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(526, 49);
            this.navigationPanel.TabIndex = 59;
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.Controls.Add(this.delimiter2);
            this.panel16.Controls.Add(this.catalogButton);
            this.panel16.Controls.Add(this.delimiter1);
            this.panel16.Controls.Add(this.mainButton);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 9);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(129, 34);
            this.panel16.TabIndex = 55;
            // 
            // delimiter2
            // 
            this.delimiter2.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiter2.Location = new System.Drawing.Point(124, 0);
            this.delimiter2.Name = "delimiter2";
            this.delimiter2.Size = new System.Drawing.Size(5, 34);
            this.delimiter2.TabIndex = 70;
            // 
            // catalogButton
            // 
            this.catalogButton.Animated = true;
            this.catalogButton.BorderColor = System.Drawing.Color.Gray;
            this.catalogButton.BorderRadius = 17;
            this.catalogButton.BorderThickness = 1;
            this.catalogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.catalogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.catalogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.catalogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.catalogButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.catalogButton.FillColor = System.Drawing.Color.Transparent;
            this.catalogButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.catalogButton.ForeColor = System.Drawing.Color.White;
            this.catalogButton.HoverState.FillColor = System.Drawing.Color.White;
            this.catalogButton.Location = new System.Drawing.Point(39, 0);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.PressedColor = System.Drawing.Color.White;
            this.catalogButton.Size = new System.Drawing.Size(85, 34);
            this.catalogButton.TabIndex = 69;
            this.catalogButton.Text = "Каталог";
            // 
            // delimiter1
            // 
            this.delimiter1.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiter1.Location = new System.Drawing.Point(34, 0);
            this.delimiter1.Name = "delimiter1";
            this.delimiter1.Size = new System.Drawing.Size(5, 34);
            this.delimiter1.TabIndex = 68;
            // 
            // bottomNavigationPanel
            // 
            this.bottomNavigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomNavigationPanel.Location = new System.Drawing.Point(0, 43);
            this.bottomNavigationPanel.Name = "bottomNavigationPanel";
            this.bottomNavigationPanel.Size = new System.Drawing.Size(526, 6);
            this.bottomNavigationPanel.TabIndex = 0;
            this.bottomNavigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // topNavigationPanel
            // 
            this.topNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.topNavigationPanel.Name = "topNavigationPanel";
            this.topNavigationPanel.Size = new System.Drawing.Size(526, 9);
            this.topNavigationPanel.TabIndex = 54;
            this.topNavigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // mainButton
            // 
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainButton.Image = ((System.Drawing.Image)(resources.GetObject("mainButton.Image")));
            this.mainButton.Location = new System.Drawing.Point(0, 0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(34, 34);
            this.mainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainButton.TabIndex = 57;
            this.mainButton.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Image = global::GameEnergy.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(69, 18);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 15);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 7;
            this.closeButton.TabStop = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Image = global::GameEnergy.Properties.Resources.maximaze;
            this.maximizeButton.Location = new System.Drawing.Point(43, 18);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(15, 15);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizeButton.TabIndex = 6;
            this.maximizeButton.TabStop = false;
            // 
            // restoreButton
            // 
            this.restoreButton.Image = global::GameEnergy.Properties.Resources.restore;
            this.restoreButton.Location = new System.Drawing.Point(43, 18);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(15, 15);
            this.restoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreButton.TabIndex = 5;
            this.restoreButton.TabStop = false;
            this.restoreButton.Visible = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::GameEnergy.Properties.Resources.collapse;
            this.minimizeButton.Location = new System.Drawing.Point(17, 18);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TabStop = false;
            // 
            // notifyPanel
            // 
            this.notifyPanel.BorderRadius = 5;
            this.notifyPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.notifyPanel.Location = new System.Drawing.Point(397, 9);
            this.notifyPanel.Name = "notifyPanel";
            this.notifyPanel.Size = new System.Drawing.Size(12, 12);
            this.notifyPanel.TabIndex = 92;
            this.notifyPanel.Visible = false;
            // 
            // cartNotifiPanel
            // 
            this.cartNotifiPanel.BorderRadius = 5;
            this.cartNotifiPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.cartNotifiPanel.Location = new System.Drawing.Point(514, 9);
            this.cartNotifiPanel.Name = "cartNotifiPanel";
            this.cartNotifiPanel.Size = new System.Drawing.Size(12, 12);
            this.cartNotifiPanel.TabIndex = 93;
            this.cartNotifiPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(370, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 34);
            this.panel1.TabIndex = 101;
            // 
            // notificationsButton
            // 
            this.notificationsButton.Animated = true;
            this.notificationsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.notificationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notificationsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notificationsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notificationsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notificationsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.notificationsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.notificationsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notificationsButton.ForeColor = System.Drawing.Color.White;
            this.notificationsButton.Image = global::GameEnergy.Properties.Resources.notifi;
            this.notificationsButton.ImageSize = new System.Drawing.Size(19, 21);
            this.notificationsButton.Location = new System.Drawing.Point(375, 9);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.notificationsButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.notificationsButton.Size = new System.Drawing.Size(34, 34);
            this.notificationsButton.TabIndex = 100;
            // 
            // delimiter3
            // 
            this.delimiter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter3.Location = new System.Drawing.Point(409, 9);
            this.delimiter3.Name = "delimiter3";
            this.delimiter3.Size = new System.Drawing.Size(5, 34);
            this.delimiter3.TabIndex = 98;
            // 
            // profileButton
            // 
            this.profileButton.Animated = true;
            this.profileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.profileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Image = global::GameEnergy.Properties.Resources.avatarButtonImage;
            this.profileButton.Location = new System.Drawing.Point(414, 9);
            this.profileButton.Name = "profileButton";
            this.profileButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profileButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profileButton.Size = new System.Drawing.Size(34, 34);
            this.profileButton.TabIndex = 99;
            // 
            // delimiter5
            // 
            this.delimiter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter5.Location = new System.Drawing.Point(448, 9);
            this.delimiter5.Name = "delimiter5";
            this.delimiter5.Size = new System.Drawing.Size(5, 34);
            this.delimiter5.TabIndex = 97;
            // 
            // libraryButton
            // 
            this.libraryButton.Animated = true;
            this.libraryButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.libraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.libraryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.libraryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.libraryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.libraryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.libraryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.libraryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.libraryButton.ForeColor = System.Drawing.Color.White;
            this.libraryButton.Image = global::GameEnergy.Properties.Resources.whiteLike;
            this.libraryButton.ImageSize = new System.Drawing.Size(22, 20);
            this.libraryButton.Location = new System.Drawing.Point(453, 9);
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.libraryButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.libraryButton.Size = new System.Drawing.Size(34, 34);
            this.libraryButton.TabIndex = 96;
            // 
            // delimiter4
            // 
            this.delimiter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.delimiter4.Location = new System.Drawing.Point(487, 9);
            this.delimiter4.Name = "delimiter4";
            this.delimiter4.Size = new System.Drawing.Size(5, 34);
            this.delimiter4.TabIndex = 95;
            // 
            // cartButton
            // 
            this.cartButton.Animated = true;
            this.cartButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cartButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Image = global::GameEnergy.Properties.Resources.cart;
            this.cartButton.ImageSize = new System.Drawing.Size(22, 20);
            this.cartButton.Location = new System.Drawing.Point(492, 9);
            this.cartButton.Name = "cartButton";
            this.cartButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cartButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cartButton.Size = new System.Drawing.Size(34, 34);
            this.cartButton.TabIndex = 94;
            // 
            // searchButton
            // 
            this.searchButton.Animated = true;
            this.searchButton.BorderColor = System.Drawing.Color.Gray;
            this.searchButton.BorderRadius = 17;
            this.searchButton.BorderThickness = 1;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.FillColor = System.Drawing.Color.Transparent;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::GameEnergy.Properties.Resources.magnifyingGlass;
            this.searchButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchButton.Location = new System.Drawing.Point(129, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.PressedColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(241, 34);
            this.searchButton.TabIndex = 102;
            this.searchButton.Text = "Поиск";
            this.searchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.topRightPanel);
            this.Controls.Add(this.topLeftPanel);
            this.Controls.Add(this.line);
            this.Name = "NavigationControl";
            this.Size = new System.Drawing.Size(726, 52);
            this.Load += new System.EventHandler(this.NavigationControl_Load);
            this.topRightPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button line;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox maximizeButton;
        private System.Windows.Forms.PictureBox restoreButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel delimiter2;
        private Guna.UI2.WinForms.Guna2Button catalogButton;
        private System.Windows.Forms.Panel delimiter1;
        private System.Windows.Forms.PictureBox mainButton;
        private System.Windows.Forms.Panel bottomNavigationPanel;
        private System.Windows.Forms.Panel topNavigationPanel;
        private Guna.UI2.WinForms.Guna2Panel cartNotifiPanel;
        private Guna.UI2.WinForms.Guna2Panel notifyPanel;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton notificationsButton;
        private System.Windows.Forms.Panel delimiter3;
        private Guna.UI2.WinForms.Guna2CircleButton profileButton;
        private System.Windows.Forms.Panel delimiter5;
        private Guna.UI2.WinForms.Guna2CircleButton libraryButton;
        private System.Windows.Forms.Panel delimiter4;
        private Guna.UI2.WinForms.Guna2CircleButton cartButton;
    }
}
