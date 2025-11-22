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
            this.GamesTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.newGames = new System.Windows.Forms.TabPage();
            this.newGamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topSellers = new System.Windows.Forms.TabPage();
            this.topSellersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.latestArrivals = new System.Windows.Forms.TabPage();
            this.latestArrivalsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.delimiterPpanel4 = new System.Windows.Forms.Panel();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainImage5 = new System.Windows.Forms.PictureBox();
            this.mainImage4 = new System.Windows.Forms.PictureBox();
            this.mainImageLabel1 = new System.Windows.Forms.Label();
            this.mainImage2 = new System.Windows.Forms.PictureBox();
            this.mainImage1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hitGamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.delimiterPpanel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gamesSlidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.delimiterPpanel1 = new System.Windows.Forms.Panel();
            this.delimiterPpanel3 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.GamesTabControl.SuspendLayout();
            this.newGames.SuspendLayout();
            this.topSellers.SuspendLayout();
            this.latestArrivals.SuspendLayout();
            this.bannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.delimiterPpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.mainPanel.Controls.Add(this.GamesTabControl);
            this.mainPanel.Controls.Add(this.delimiterPpanel4);
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
            // GamesTabControl
            // 
            this.GamesTabControl.Controls.Add(this.newGames);
            this.GamesTabControl.Controls.Add(this.topSellers);
            this.GamesTabControl.Controls.Add(this.latestArrivals);
            this.GamesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesTabControl.ItemSize = new System.Drawing.Size(173, 40);
            this.GamesTabControl.Location = new System.Drawing.Point(100, 297);
            this.GamesTabControl.Name = "GamesTabControl";
            this.GamesTabControl.SelectedIndex = 0;
            this.GamesTabControl.Size = new System.Drawing.Size(526, 81);
            this.GamesTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.GamesTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(46)))));
            this.GamesTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.GamesTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.GamesTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.GamesTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.GamesTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.GamesTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.GamesTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.GamesTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.GamesTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.GamesTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.GamesTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.GamesTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.GamesTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.GamesTabControl.TabButtonSize = new System.Drawing.Size(173, 40);
            this.GamesTabControl.TabIndex = 31;
            this.GamesTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.GamesTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // newGames
            // 
            this.newGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.newGames.Controls.Add(this.newGamesPanel);
            this.newGames.Location = new System.Drawing.Point(4, 44);
            this.newGames.Name = "newGames";
            this.newGames.Padding = new System.Windows.Forms.Padding(3);
            this.newGames.Size = new System.Drawing.Size(518, 33);
            this.newGames.TabIndex = 0;
            this.newGames.Text = "Новинки";
            // 
            // newGamesPanel
            // 
            this.newGamesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGamesPanel.Location = new System.Drawing.Point(3, 3);
            this.newGamesPanel.Name = "newGamesPanel";
            this.newGamesPanel.Size = new System.Drawing.Size(512, 27);
            this.newGamesPanel.TabIndex = 75;
            // 
            // topSellers
            // 
            this.topSellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topSellers.Controls.Add(this.topSellersPanel);
            this.topSellers.Location = new System.Drawing.Point(4, 44);
            this.topSellers.Name = "topSellers";
            this.topSellers.Padding = new System.Windows.Forms.Padding(3);
            this.topSellers.Size = new System.Drawing.Size(518, 33);
            this.topSellers.TabIndex = 1;
            this.topSellers.Text = "Лидеры продаж";
            // 
            // topSellersPanel
            // 
            this.topSellersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topSellersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSellersPanel.Location = new System.Drawing.Point(3, 3);
            this.topSellersPanel.Name = "topSellersPanel";
            this.topSellersPanel.Size = new System.Drawing.Size(512, 27);
            this.topSellersPanel.TabIndex = 76;
            // 
            // latestArrivals
            // 
            this.latestArrivals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.latestArrivals.Controls.Add(this.latestArrivalsPanel);
            this.latestArrivals.Location = new System.Drawing.Point(4, 44);
            this.latestArrivals.Name = "latestArrivals";
            this.latestArrivals.Padding = new System.Windows.Forms.Padding(3);
            this.latestArrivals.Size = new System.Drawing.Size(518, 33);
            this.latestArrivals.TabIndex = 2;
            this.latestArrivals.Text = "Последние поступления";
            // 
            // latestArrivalsPanel
            // 
            this.latestArrivalsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latestArrivalsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latestArrivalsPanel.Location = new System.Drawing.Point(3, 3);
            this.latestArrivalsPanel.Name = "latestArrivalsPanel";
            this.latestArrivalsPanel.Size = new System.Drawing.Size(512, 27);
            this.latestArrivalsPanel.TabIndex = 77;
            // 
            // delimiterPpanel4
            // 
            this.delimiterPpanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiterPpanel4.Location = new System.Drawing.Point(100, 267);
            this.delimiterPpanel4.Name = "delimiterPpanel4";
            this.delimiterPpanel4.Size = new System.Drawing.Size(526, 30);
            this.delimiterPpanel4.TabIndex = 30;
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
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel6);
            this.topPanel.Controls.Add(this.delimiterPpanel2);
            this.topPanel.Controls.Add(this.panel4);
            this.topPanel.Controls.Add(this.delimiterPpanel1);
            this.topPanel.Controls.Add(this.delimiterPpanel3);
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
            this.panel6.Location = new System.Drawing.Point(44, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 115);
            this.panel6.TabIndex = 7;
            // 
            // hitGamesPanel
            // 
            this.hitGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitGamesPanel.Location = new System.Drawing.Point(0, 0);
            this.hitGamesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.hitGamesPanel.Name = "hitGamesPanel";
            this.hitGamesPanel.Size = new System.Drawing.Size(482, 115);
            this.hitGamesPanel.TabIndex = 27;
            this.hitGamesPanel.WrapContents = false;
            // 
            // delimiterPpanel2
            // 
            this.delimiterPpanel2.Controls.Add(this.pictureBox1);
            this.delimiterPpanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.delimiterPpanel2.Location = new System.Drawing.Point(0, 30);
            this.delimiterPpanel2.Name = "delimiterPpanel2";
            this.delimiterPpanel2.Size = new System.Drawing.Size(44, 115);
            this.delimiterPpanel2.TabIndex = 5;
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
            // delimiterPpanel1
            // 
            this.delimiterPpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.delimiterPpanel1.Location = new System.Drawing.Point(0, 0);
            this.delimiterPpanel1.Name = "delimiterPpanel1";
            this.delimiterPpanel1.Size = new System.Drawing.Size(526, 30);
            this.delimiterPpanel1.TabIndex = 3;
            // 
            // delimiterPpanel3
            // 
            this.delimiterPpanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delimiterPpanel3.Location = new System.Drawing.Point(0, 145);
            this.delimiterPpanel3.Name = "delimiterPpanel3";
            this.delimiterPpanel3.Size = new System.Drawing.Size(526, 30);
            this.delimiterPpanel3.TabIndex = 0;
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
            this.GamesTabControl.ResumeLayout(false);
            this.newGames.ResumeLayout(false);
            this.topSellers.ResumeLayout(false);
            this.latestArrivals.ResumeLayout(false);
            this.bannerPanel.ResumeLayout(false);
            this.bannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.delimiterPpanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel delimiterPpanel1;
        private System.Windows.Forms.Panel delimiterPpanel3;
        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainImage5;
        private System.Windows.Forms.PictureBox mainImage4;
        private System.Windows.Forms.Label mainImageLabel1;
        private System.Windows.Forms.PictureBox mainImage2;
        private System.Windows.Forms.PictureBox mainImage1;
        private System.Windows.Forms.Panel delimiterPpanel4;
        private Guna.UI2.WinForms.Guna2TabControl GamesTabControl;
        private System.Windows.Forms.TabPage newGames;
        private System.Windows.Forms.FlowLayoutPanel newGamesPanel;
        private System.Windows.Forms.TabPage topSellers;
        private System.Windows.Forms.FlowLayoutPanel topSellersPanel;
        private System.Windows.Forms.TabPage latestArrivals;
        private System.Windows.Forms.FlowLayoutPanel latestArrivalsPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel hitGamesPanel;
        private System.Windows.Forms.Panel delimiterPpanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}