namespace GameEnergy.AppForms.UserForms
{
    partial class CartForm
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
            this.GamesTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.newGames = new System.Windows.Forms.TabPage();
            this.newGamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topSellers = new System.Windows.Forms.TabPage();
            this.topSellersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.latestArrivals = new System.Windows.Forms.TabPage();
            this.latestArrivalsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GamesTabControl.SuspendLayout();
            this.newGames.SuspendLayout();
            this.topSellers.SuspendLayout();
            this.latestArrivals.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamesTabControl
            // 
            this.GamesTabControl.Controls.Add(this.newGames);
            this.GamesTabControl.Controls.Add(this.topSellers);
            this.GamesTabControl.Controls.Add(this.latestArrivals);
            this.GamesTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamesTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesTabControl.ItemSize = new System.Drawing.Size(173, 40);
            this.GamesTabControl.Location = new System.Drawing.Point(0, 0);
            this.GamesTabControl.Name = "GamesTabControl";
            this.GamesTabControl.SelectedIndex = 0;
            this.GamesTabControl.Size = new System.Drawing.Size(726, 81);
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
            this.GamesTabControl.TabIndex = 32;
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
            this.newGames.Size = new System.Drawing.Size(718, 33);
            this.newGames.TabIndex = 0;
            this.newGames.Text = "Новинки";
            // 
            // newGamesPanel
            // 
            this.newGamesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGamesPanel.Location = new System.Drawing.Point(3, 3);
            this.newGamesPanel.Name = "newGamesPanel";
            this.newGamesPanel.Size = new System.Drawing.Size(712, 27);
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
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.GamesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.GamesTabControl.ResumeLayout(false);
            this.newGames.ResumeLayout(false);
            this.topSellers.ResumeLayout(false);
            this.latestArrivals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl GamesTabControl;
        private System.Windows.Forms.TabPage newGames;
        private System.Windows.Forms.FlowLayoutPanel newGamesPanel;
        private System.Windows.Forms.TabPage topSellers;
        private System.Windows.Forms.FlowLayoutPanel topSellersPanel;
        private System.Windows.Forms.TabPage latestArrivals;
        private System.Windows.Forms.FlowLayoutPanel latestArrivalsPanel;
    }
}