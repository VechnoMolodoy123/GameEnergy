namespace GameEnergy.AppForms.UserForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationControl = new GameEnergy.CustomControls.NavigationControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.delimiterPanel4 = new System.Windows.Forms.Panel();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hitGamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.delimiterPanel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gamesSlidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.delimiterPanel1 = new System.Windows.Forms.Panel();
            this.delimiterPanel3 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.categoryButtonsPanel = new System.Windows.Forms.Panel();
            this.latestArrivalsButton = new Guna.UI2.WinForms.Guna2Button();
            this.topSellersButton = new Guna.UI2.WinForms.Guna2Button();
            this.newGamesButton = new Guna.UI2.WinForms.Guna2Button();
            this.categoryGamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainImage1 = new System.Windows.Forms.PictureBox();
            this.mainImage2 = new System.Windows.Forms.PictureBox();
            this.mainImageLabel1 = new System.Windows.Forms.Label();
            this.mainImage4 = new System.Windows.Forms.PictureBox();
            this.mainImage5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.delimiterPanel4.SuspendLayout();
            this.bannerPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.delimiterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.categoryButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage5)).BeginInit();
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
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.rightPanel = null;
            this.navigationControl.RightPanelWidth = 0;
            this.navigationControl.Size = new System.Drawing.Size(726, 52);
            this.navigationControl.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.categoryGamesPanel);
            this.mainPanel.Controls.Add(this.delimiterPanel4);
            this.mainPanel.Controls.Add(this.bannerPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 1;
            // 
            // delimiterPanel4
            // 
            this.delimiterPanel4.Controls.Add(this.categoryButtonsPanel);
            this.delimiterPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiterPanel4.Location = new System.Drawing.Point(100, 267);
            this.delimiterPanel4.Name = "delimiterPanel4";
            this.delimiterPanel4.Size = new System.Drawing.Size(526, 50);
            this.delimiterPanel4.TabIndex = 30;
            // 
            // bannerPanel
            // 
            this.bannerPanel.Controls.Add(this.label3);
            this.bannerPanel.Controls.Add(this.label2);
            this.bannerPanel.Controls.Add(this.label1);
            this.bannerPanel.Controls.Add(this.mainImage5);
            this.bannerPanel.Controls.Add(this.mainImage4);
            this.bannerPanel.Controls.Add(this.mainImageLabel1);
            this.bannerPanel.Controls.Add(this.mainImage2);
            this.bannerPanel.Controls.Add(this.mainImage1);
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(100, 175);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(526, 92);
            this.bannerPanel.TabIndex = 29;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel6);
            this.topPanel.Controls.Add(this.delimiterPanel2);
            this.topPanel.Controls.Add(this.panel4);
            this.topPanel.Controls.Add(this.delimiterPanel1);
            this.topPanel.Controls.Add(this.delimiterPanel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(100, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(526, 175);
            this.topPanel.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.hitGamesPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(56, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 115);
            this.panel6.TabIndex = 7;
            // 
            // hitGamesPanel
            // 
            this.hitGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitGamesPanel.Location = new System.Drawing.Point(0, 0);
            this.hitGamesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.hitGamesPanel.Name = "hitGamesPanel";
            this.hitGamesPanel.Size = new System.Drawing.Size(470, 115);
            this.hitGamesPanel.TabIndex = 27;
            this.hitGamesPanel.WrapContents = false;
            // 
            // delimiterPanel2
            // 
            this.delimiterPanel2.Controls.Add(this.pictureBox1);
            this.delimiterPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiterPanel2.Location = new System.Drawing.Point(0, 30);
            this.delimiterPanel2.Name = "delimiterPanel2";
            this.delimiterPanel2.Size = new System.Drawing.Size(56, 115);
            this.delimiterPanel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameEnergy.Properties.Resources.hitLabel;
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.gamesSlidePanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 115);
            this.panel4.TabIndex = 4;
            // 
            // gamesSlidePanel
            // 
            this.gamesSlidePanel.AutoSize = true;
            this.gamesSlidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamesSlidePanel.Location = new System.Drawing.Point(0, 0);
            this.gamesSlidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamesSlidePanel.Name = "gamesSlidePanel";
            this.gamesSlidePanel.Size = new System.Drawing.Size(0, 115);
            this.gamesSlidePanel.TabIndex = 26;
            this.gamesSlidePanel.WrapContents = false;
            // 
            // delimiterPanel1
            // 
            this.delimiterPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiterPanel1.Location = new System.Drawing.Point(0, 0);
            this.delimiterPanel1.Name = "delimiterPanel1";
            this.delimiterPanel1.Size = new System.Drawing.Size(526, 30);
            this.delimiterPanel1.TabIndex = 3;
            // 
            // delimiterPanel3
            // 
            this.delimiterPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delimiterPanel3.Location = new System.Drawing.Point(0, 145);
            this.delimiterPanel3.Name = "delimiterPanel3";
            this.delimiterPanel3.Size = new System.Drawing.Size(526, 30);
            this.delimiterPanel3.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(626, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 378);
            this.rightPanel.TabIndex = 27;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 378);
            this.leftPanel.TabIndex = 26;
            // 
            // categoryButtonsPanel
            // 
            this.categoryButtonsPanel.Controls.Add(this.latestArrivalsButton);
            this.categoryButtonsPanel.Controls.Add(this.topSellersButton);
            this.categoryButtonsPanel.Controls.Add(this.newGamesButton);
            this.categoryButtonsPanel.Location = new System.Drawing.Point(49, 20);
            this.categoryButtonsPanel.Name = "categoryButtonsPanel";
            this.categoryButtonsPanel.Size = new System.Drawing.Size(427, 30);
            this.categoryButtonsPanel.TabIndex = 34;
            // 
            // latestArrivalsButton
            // 
            this.latestArrivalsButton.BorderColor = System.Drawing.Color.Empty;
            this.latestArrivalsButton.BorderRadius = 10;
            this.latestArrivalsButton.BorderThickness = 1;
            this.latestArrivalsButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.latestArrivalsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.latestArrivalsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.latestArrivalsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.latestArrivalsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.latestArrivalsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.latestArrivalsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.latestArrivalsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.latestArrivalsButton.ForeColor = System.Drawing.Color.White;
            this.latestArrivalsButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.latestArrivalsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.latestArrivalsButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.latestArrivalsButton.Location = new System.Drawing.Point(235, 0);
            this.latestArrivalsButton.Name = "latestArrivalsButton";
            this.latestArrivalsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.latestArrivalsButton.Size = new System.Drawing.Size(192, 30);
            this.latestArrivalsButton.TabIndex = 2;
            this.latestArrivalsButton.Text = "ПОСЛЕДНИЕ ПОСТУПЛЕНИЯ";
            this.latestArrivalsButton.Click += new System.EventHandler(this.latestArrivalsButton_Click);
            // 
            // topSellersButton
            // 
            this.topSellersButton.BorderColor = System.Drawing.Color.Empty;
            this.topSellersButton.BorderRadius = 10;
            this.topSellersButton.BorderThickness = 1;
            this.topSellersButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.topSellersButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.topSellersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.topSellersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.topSellersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.topSellersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.topSellersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topSellersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.topSellersButton.ForeColor = System.Drawing.Color.White;
            this.topSellersButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topSellersButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topSellersButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.topSellersButton.Location = new System.Drawing.Point(94, 0);
            this.topSellersButton.Name = "topSellersButton";
            this.topSellersButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topSellersButton.Size = new System.Drawing.Size(135, 30);
            this.topSellersButton.TabIndex = 1;
            this.topSellersButton.Text = "ЛИДЕРЫ ПРОДАЖ";
            this.topSellersButton.Click += new System.EventHandler(this.topSellersButton_Click);
            // 
            // newGamesButton
            // 
            this.newGamesButton.BorderColor = System.Drawing.Color.Empty;
            this.newGamesButton.BorderRadius = 10;
            this.newGamesButton.BorderThickness = 1;
            this.newGamesButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.newGamesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.newGamesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newGamesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newGamesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newGamesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newGamesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newGamesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.newGamesButton.ForeColor = System.Drawing.Color.White;
            this.newGamesButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newGamesButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newGamesButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.newGamesButton.Location = new System.Drawing.Point(0, 0);
            this.newGamesButton.Name = "newGamesButton";
            this.newGamesButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newGamesButton.Size = new System.Drawing.Size(88, 30);
            this.newGamesButton.TabIndex = 0;
            this.newGamesButton.Text = "НОВИНКИ";
            this.newGamesButton.Click += new System.EventHandler(this.newGamesButton_Click);
            // 
            // categoryGamesPanel
            // 
            this.categoryGamesPanel.AutoSize = true;
            this.categoryGamesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryGamesPanel.Location = new System.Drawing.Point(100, 317);
            this.categoryGamesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.categoryGamesPanel.Name = "categoryGamesPanel";
            this.categoryGamesPanel.Size = new System.Drawing.Size(526, 0);
            this.categoryGamesPanel.TabIndex = 31;
            this.categoryGamesPanel.WrapContents = false;
            // 
            // mainImage1
            // 
            this.mainImage1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainImage1.Image = global::GameEnergy.Properties.Resources.MainDiscount;
            this.mainImage1.Location = new System.Drawing.Point(0, 0);
            this.mainImage1.Name = "mainImage1";
            this.mainImage1.Size = new System.Drawing.Size(132, 92);
            this.mainImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage1.TabIndex = 0;
            this.mainImage1.TabStop = false;
            // 
            // mainImage2
            // 
            this.mainImage2.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainImage2.Image = global::GameEnergy.Properties.Resources.MainOperator;
            this.mainImage2.Location = new System.Drawing.Point(132, 0);
            this.mainImage2.Name = "mainImage2";
            this.mainImage2.Size = new System.Drawing.Size(131, 92);
            this.mainImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage2.TabIndex = 1;
            this.mainImage2.TabStop = false;
            // 
            // mainImageLabel1
            // 
            this.mainImageLabel1.AutoSize = true;
            this.mainImageLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainImageLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.mainImageLabel1.Location = new System.Drawing.Point(22, 48);
            this.mainImageLabel1.Name = "mainImageLabel1";
            this.mainImageLabel1.Size = new System.Drawing.Size(86, 32);
            this.mainImageLabel1.TabIndex = 2;
            this.mainImageLabel1.Text = "Скидки\r\nкруглый год";
            this.mainImageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainImage4
            // 
            this.mainImage4.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainImage4.Image = global::GameEnergy.Properties.Resources.MainActive;
            this.mainImage4.Location = new System.Drawing.Point(263, 0);
            this.mainImage4.Name = "mainImage4";
            this.mainImage4.Size = new System.Drawing.Size(131, 92);
            this.mainImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage4.TabIndex = 4;
            this.mainImage4.TabStop = false;
            // 
            // mainImage5
            // 
            this.mainImage5.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainImage5.Image = global::GameEnergy.Properties.Resources.MainGame;
            this.mainImage5.Location = new System.Drawing.Point(394, 0);
            this.mainImage5.Name = "mainImage5";
            this.mainImage5.Size = new System.Drawing.Size(132, 92);
            this.mainImage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage5.TabIndex = 5;
            this.mainImage5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(151, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оперативная\r\nподдержка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(291, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Активное\r\nкомьюнити";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(432, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Любовь\r\nк играм";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.delimiterPanel4.ResumeLayout(false);
            this.bannerPanel.ResumeLayout(false);
            this.bannerPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.delimiterPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.categoryButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel gamesSlidePanel;
        private System.Windows.Forms.Panel delimiterPanel1;
        private System.Windows.Forms.Panel delimiterPanel3;
        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Panel delimiterPanel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel hitGamesPanel;
        private System.Windows.Forms.Panel delimiterPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel categoryButtonsPanel;
        private Guna.UI2.WinForms.Guna2Button latestArrivalsButton;
        private Guna.UI2.WinForms.Guna2Button topSellersButton;
        private Guna.UI2.WinForms.Guna2Button newGamesButton;
        private System.Windows.Forms.FlowLayoutPanel categoryGamesPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainImage5;
        private System.Windows.Forms.PictureBox mainImage4;
        private System.Windows.Forms.Label mainImageLabel1;
        private System.Windows.Forms.PictureBox mainImage2;
        private System.Windows.Forms.PictureBox mainImage1;
    }
}