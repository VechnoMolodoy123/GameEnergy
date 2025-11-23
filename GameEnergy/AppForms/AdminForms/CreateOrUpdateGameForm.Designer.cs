namespace GameEnergy.AppForms.AdminForms
{
    partial class CreateOrUpdateGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrUpdateGameForm));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gamePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.trailerNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.developerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.categoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.discountTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.genreCheckedList = new System.Windows.Forms.CheckedListBox();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.SuspendLayout();
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
            // FormRounded
            // 
            this.FormRounded.BorderRadius = 11;
            this.FormRounded.ContainerControl = this;
            this.FormRounded.DockIndicatorTransparencyValue = 0.6D;
            this.FormRounded.DragForm = false;
            this.FormRounded.ResizeForm = false;
            this.FormRounded.TransparentWhileDrag = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(133, 20);
            this.titleLabel.TabIndex = 35;
            this.titleLabel.Text = "Добавить игру";
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
            this.nameTextBox.Location = new System.Drawing.Point(116, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.nameTextBox.PlaceholderText = "Название";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(173, 36);
            this.nameTextBox.TabIndex = 44;
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BorderRadius = 13;
            this.gamePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamePictureBox.ImageRotate = 0F;
            this.gamePictureBox.Location = new System.Drawing.Point(16, 84);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(85, 106);
            this.gamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePictureBox.TabIndex = 42;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.Click += new System.EventHandler(this.GamePictureBox_Click);
            // 
            // trailerNameTextBox
            // 
            this.trailerNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.trailerNameTextBox.BorderRadius = 10;
            this.trailerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trailerNameTextBox.DefaultText = "";
            this.trailerNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.trailerNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.trailerNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trailerNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trailerNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.trailerNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.trailerNameTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.trailerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trailerNameTextBox.ForeColor = System.Drawing.Color.White;
            this.trailerNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.trailerNameTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.trailerNameTextBox.Location = new System.Drawing.Point(116, 142);
            this.trailerNameTextBox.Name = "trailerNameTextBox";
            this.trailerNameTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.trailerNameTextBox.PlaceholderText = "Код ролика";
            this.trailerNameTextBox.SelectedText = "";
            this.trailerNameTextBox.Size = new System.Drawing.Size(173, 36);
            this.trailerNameTextBox.TabIndex = 48;
            // 
            // developerComboBox
            // 
            this.developerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.developerComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.developerComboBox.BorderRadius = 10;
            this.developerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.developerComboBox.Location = new System.Drawing.Point(16, 322);
            this.developerComboBox.Name = "developerComboBox";
            this.developerComboBox.Size = new System.Drawing.Size(273, 36);
            this.developerComboBox.StartIndex = 0;
            this.developerComboBox.TabIndex = 47;
            this.developerComboBox.TabStop = false;
            this.developerComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.categoryComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.categoryComboBox.BorderRadius = 10;
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.categoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.categoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.categoryComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.categoryComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.categoryComboBox.ItemHeight = 30;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Категория (не обязательное поле)",
            "Хиты продаж",
            "Новинки",
            "Лидеры продаж",
            "Последние поступления"});
            this.categoryComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.categoryComboBox.Location = new System.Drawing.Point(16, 372);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(273, 36);
            this.categoryComboBox.StartIndex = 0;
            this.categoryComboBox.TabIndex = 49;
            this.categoryComboBox.TabStop = false;
            this.categoryComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.descriptionTextBox.BorderRadius = 10;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.descriptionTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.descriptionTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 423);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.PlaceholderText = "Описание";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(273, 36);
            this.descriptionTextBox.TabIndex = 50;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceTextBox.BorderRadius = 10;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.priceTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.priceTextBox.Location = new System.Drawing.Point(16, 473);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.priceTextBox.PlaceholderText = "Цена";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(114, 36);
            this.priceTextBox.TabIndex = 51;
            // 
            // discountTextBox
            // 
            this.discountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountTextBox.BorderRadius = 10;
            this.discountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountTextBox.DefaultText = "";
            this.discountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.discountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.discountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.discountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.discountTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountTextBox.ForeColor = System.Drawing.Color.White;
            this.discountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.discountTextBox.Location = new System.Drawing.Point(175, 473);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.discountTextBox.PlaceholderText = "Скидка";
            this.discountTextBox.SelectedText = "";
            this.discountTextBox.Size = new System.Drawing.Size(114, 36);
            this.discountTextBox.TabIndex = 52;
            // 
            // addGameButton
            // 
            this.addGameButton.BorderColor = System.Drawing.Color.Green;
            this.addGameButton.BorderRadius = 10;
            this.addGameButton.BorderThickness = 1;
            this.addGameButton.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.addGameButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.addGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addGameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.addGameButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGameButton.ForeColor = System.Drawing.Color.White;
            this.addGameButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addGameButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.addGameButton.Location = new System.Drawing.Point(16, 525);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.addGameButton.Size = new System.Drawing.Size(273, 36);
            this.addGameButton.TabIndex = 53;
            this.addGameButton.Text = "Добавить игру";
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // genreCheckedList
            // 
            this.genreCheckedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.genreCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreCheckedList.ColumnWidth = 187;
            this.genreCheckedList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genreCheckedList.ForeColor = System.Drawing.Color.White;
            this.genreCheckedList.FormattingEnabled = true;
            this.genreCheckedList.Items.AddRange(new object[] {
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
            this.genreCheckedList.Location = new System.Drawing.Point(16, 206);
            this.genreCheckedList.MultiColumn = true;
            this.genreCheckedList.Name = "genreCheckedList";
            this.genreCheckedList.Size = new System.Drawing.Size(508, 100);
            this.genreCheckedList.TabIndex = 45;
            // 
            // CreateOrUpdateGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(305, 577);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.trailerNameTextBox);
            this.Controls.Add(this.developerComboBox);
            this.Controls.Add(this.genreCheckedList);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gamePictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateOrUpdateGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrUpdateGameForm";
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox gamePictureBox;
        private Guna.UI2.WinForms.Guna2TextBox trailerNameTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox developerComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox categoryComboBox;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private Guna.UI2.WinForms.Guna2TextBox discountTextBox;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2Button addGameButton;
        private System.Windows.Forms.CheckedListBox genreCheckedList;
    }
}