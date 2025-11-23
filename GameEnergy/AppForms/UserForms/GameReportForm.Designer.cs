namespace GameEnergy.AppForms.UserForms
{
    partial class GameReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameReportForm));
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.reportReasonComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reportMessageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.reportReasonLabel = new System.Windows.Forms.Label();
            this.sendReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
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
            // reportReasonComboBox
            // 
            this.reportReasonComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.reportReasonComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportReasonComboBox.BorderRadius = 10;
            this.reportReasonComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportReasonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportReasonComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportReasonComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportReasonComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportReasonComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportReasonComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportReasonComboBox.ForeColor = System.Drawing.Color.White;
            this.reportReasonComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportReasonComboBox.ItemHeight = 30;
            this.reportReasonComboBox.Items.AddRange(new object[] {
            "Дубль",
            "Неверная информация",
            "Другое"});
            this.reportReasonComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.reportReasonComboBox.Location = new System.Drawing.Point(16, 122);
            this.reportReasonComboBox.Name = "reportReasonComboBox";
            this.reportReasonComboBox.Size = new System.Drawing.Size(275, 36);
            this.reportReasonComboBox.TabIndex = 32;
            this.reportReasonComboBox.TabStop = false;
            this.reportReasonComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 44);
            this.titleLabel.TabIndex = 35;
            this.titleLabel.Text = "Жалоба на игру: ";
            // 
            // reportMessageTextBox
            // 
            this.reportMessageTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportMessageTextBox.BorderRadius = 10;
            this.reportMessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reportMessageTextBox.DefaultText = "";
            this.reportMessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reportMessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reportMessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportMessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportMessageTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportMessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportMessageTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportMessageTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportMessageTextBox.ForeColor = System.Drawing.Color.White;
            this.reportMessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.reportMessageTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.reportMessageTextBox.Location = new System.Drawing.Point(16, 177);
            this.reportMessageTextBox.Name = "reportMessageTextBox";
            this.reportMessageTextBox.PlaceholderText = "Сообщение";
            this.reportMessageTextBox.SelectedText = "";
            this.reportMessageTextBox.Size = new System.Drawing.Size(275, 36);
            this.reportMessageTextBox.TabIndex = 37;
            // 
            // reportReasonLabel
            // 
            this.reportReasonLabel.AutoSize = true;
            this.reportReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportReasonLabel.ForeColor = System.Drawing.Color.White;
            this.reportReasonLabel.Location = new System.Drawing.Point(13, 100);
            this.reportReasonLabel.Name = "reportReasonLabel";
            this.reportReasonLabel.Size = new System.Drawing.Size(124, 15);
            this.reportReasonLabel.TabIndex = 38;
            this.reportReasonLabel.Text = "Причина репорта";
            // 
            // sendReportButton
            // 
            this.sendReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sendReportButton.BorderRadius = 10;
            this.sendReportButton.BorderThickness = 1;
            this.sendReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendReportButton.ForeColor = System.Drawing.Color.White;
            this.sendReportButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.sendReportButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendReportButton.Location = new System.Drawing.Point(151, 233);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendReportButton.Size = new System.Drawing.Size(140, 36);
            this.sendReportButton.TabIndex = 39;
            this.sendReportButton.Text = "Отправить жалобу";
            // 
            // GameReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(305, 291);
            this.Controls.Add(this.sendReportButton);
            this.Controls.Add(this.reportReasonLabel);
            this.Controls.Add(this.reportMessageTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.reportReasonComboBox);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameReportForm";
            this.Text = "GameReportForm";
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2ComboBox reportReasonComboBox;
        private Guna.UI2.WinForms.Guna2TextBox reportMessageTextBox;
        private Guna.UI2.WinForms.Guna2Button sendReportButton;
        private System.Windows.Forms.Label reportReasonLabel;
    }
}