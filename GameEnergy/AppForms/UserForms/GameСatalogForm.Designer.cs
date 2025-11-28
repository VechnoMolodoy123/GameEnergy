namespace GameEnergy.AppForms.UserForms
{
    partial class GameСatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameСatalogForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addGamePanel = new System.Windows.Forms.Panel();
            this.addGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.developerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.genreComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priceComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.navigationControl = new GameEnergy.CustomControls.NavigationControl();
            this.mainPanel.SuspendLayout();
            this.addGamePanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gamesPanel);
            this.mainPanel.Controls.Add(this.addGamePanel);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 5;
            // 
            // gamesPanel
            // 
            this.gamesPanel.AutoSize = true;
            this.gamesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gamesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamesPanel.Location = new System.Drawing.Point(100, 142);
            this.gamesPanel.Name = "gamesPanel";
            this.gamesPanel.Size = new System.Drawing.Size(526, 0);
            this.gamesPanel.TabIndex = 76;
            // 
            // addGamePanel
            // 
            this.addGamePanel.Controls.Add(this.addGameButton);
            this.addGamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGamePanel.Location = new System.Drawing.Point(100, 66);
            this.addGamePanel.Name = "addGamePanel";
            this.addGamePanel.Size = new System.Drawing.Size(526, 76);
            this.addGamePanel.TabIndex = 30;
            // 
            // addGameButton
            // 
            this.addGameButton.Animated = true;
            this.addGameButton.BorderRadius = 8;
            this.addGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addGameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.addGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGameButton.ForeColor = System.Drawing.Color.Black;
            this.addGameButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addGameButton.Location = new System.Drawing.Point(0, 20);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(155, 36);
            this.addGameButton.TabIndex = 15;
            this.addGameButton.Text = "ДОБАВИТЬ ИГРУ";
            this.addGameButton.Visible = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.developerComboBox);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.genreComboBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.priceComboBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.sortComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(100, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 36);
            this.panel2.TabIndex = 29;
            // 
            // developerComboBox
            // 
            this.developerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.developerComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.developerComboBox.BorderRadius = 10;
            this.developerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.developerComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.developerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.developerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.developerComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.developerComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.developerComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.developerComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.developerComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.developerComboBox.ForeColor = System.Drawing.Color.White;
            this.developerComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.developerComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.developerComboBox.ItemHeight = 30;
            this.developerComboBox.Items.AddRange(new object[] {
            "Разработчик",
            "CD PROJEKT RED",
            "Capcom",
            "Paradox Development Studio",
            "Sucker Punch Productions",
            "Hello Games",
            "FromSoftware",
            "Slavic Magic",
            "Bend Studio",
            "Firaxis Games",
            "Owlcat Games",
            "Warm Lamp Games",
            "Warhorse Studios",
            "id Software",
            "Ubisoft Montreal",
            "Rockstar North",
            "Embark Studios",
            "Quantic Dream",
            "Avalanche Studios",
            "4A Games",
            "Paradox Tinto",
            "Arrowhead Game Studios"});
            this.developerComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.developerComboBox.Location = new System.Drawing.Point(401, 0);
            this.developerComboBox.Name = "developerComboBox";
            this.developerComboBox.Size = new System.Drawing.Size(125, 36);
            this.developerComboBox.StartIndex = 0;
            this.developerComboBox.TabIndex = 56;
            this.developerComboBox.TabStop = false;
            this.developerComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.developerComboBox.SelectedIndexChanged += new System.EventHandler(this.developerComboBox_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(391, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 36);
            this.panel6.TabIndex = 54;
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.genreComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.genreComboBox.BorderRadius = 10;
            this.genreComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genreComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.genreComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.genreComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.genreComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.genreComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.genreComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genreComboBox.ForeColor = System.Drawing.Color.White;
            this.genreComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.genreComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.genreComboBox.ItemHeight = 30;
            this.genreComboBox.Items.AddRange(new object[] {
            "По жанру",
            "Souls-like",
            "Экшен",
            "Приключения",
            "Ролевые",
            "Симуляторы",
            "Стратегии",
            "Инди",
            "Онлайн",
            "Спорт",
            "Гонки"});
            this.genreComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.genreComboBox.Location = new System.Drawing.Point(285, 0);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(106, 36);
            this.genreComboBox.StartIndex = 0;
            this.genreComboBox.TabIndex = 53;
            this.genreComboBox.TabStop = false;
            this.genreComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(275, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 36);
            this.panel4.TabIndex = 52;
            // 
            // priceComboBox
            // 
            this.priceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.priceComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceComboBox.BorderRadius = 10;
            this.priceComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.priceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.priceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.priceComboBox.ForeColor = System.Drawing.Color.White;
            this.priceComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceComboBox.ItemHeight = 30;
            this.priceComboBox.Items.AddRange(new object[] {
            "Все цены",
            "До 100",
            "100-500",
            "500-1000",
            "1000-1500",
            "1500-2000",
            "2000-3000",
            "От 3000"});
            this.priceComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.priceComboBox.Location = new System.Drawing.Point(165, 0);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(110, 36);
            this.priceComboBox.StartIndex = 0;
            this.priceComboBox.TabIndex = 51;
            this.priceComboBox.TabStop = false;
            this.priceComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(155, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 36);
            this.panel3.TabIndex = 50;
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.sortComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sortComboBox.BorderRadius = 10;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sortComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sortComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sortComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sortComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sortComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sortComboBox.ItemHeight = 30;
            this.sortComboBox.Items.AddRange(new object[] {
            "По популярности",
            "Сначала дешевые",
            "Сначала дорогие",
            "По величине скидки",
            "По дате выхода",
            "По дате добавления",
            "По алфавиту",
            "По рейтингу критиков"});
            this.sortComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.Location = new System.Drawing.Point(0, 0);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(155, 36);
            this.sortComboBox.StartIndex = 0;
            this.sortComboBox.TabIndex = 49;
            this.sortComboBox.TabStop = false;
            this.sortComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 30);
            this.panel1.TabIndex = 28;
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
            this.navigationControl.TabIndex = 4;
            // 
            // GameСatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameСatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameСatalogForm";
            this.SizeChanged += new System.EventHandler(this.GameСatalogForm_SizeChanged);
            this.Resize += new System.EventHandler(this.GameСatalogForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addGamePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel addGamePanel;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox priceComboBox;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox sortComboBox;
        private System.Windows.Forms.FlowLayoutPanel gamesPanel;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2ComboBox genreComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox developerComboBox;
        private Guna.UI2.WinForms.Guna2Button addGameButton;
    }
}