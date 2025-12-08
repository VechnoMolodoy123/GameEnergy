namespace GameEnergy.AppForms.AdminForms
{
    partial class WriteNotifyForm
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
            this.FormRounded = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sendNotifyButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.collapseButton = new System.Windows.Forms.PictureBox();
            this.line = new Guna.UI2.WinForms.Guna2Button();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FormRounded
            // 
            this.FormRounded.AnimateWindow = true;
            this.FormRounded.AnimationInterval = 200;
            this.FormRounded.BorderRadius = 35;
            this.FormRounded.ContainerControl = this;
            this.FormRounded.DockIndicatorTransparencyValue = 0.6D;
            this.FormRounded.DragEndTransparencyValue = 0.2D;
            this.FormRounded.DragForm = false;
            this.FormRounded.HasFormShadow = false;
            this.FormRounded.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.sendNotifyButton);
            this.guna2Panel1.Controls.Add(this.titleTextBox);
            this.guna2Panel1.Controls.Add(this.navigationPanel);
            this.guna2Panel1.Controls.Add(this.descriptionTextBox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(245, 285);
            this.guna2Panel1.TabIndex = 5;
            // 
            // sendNotifyButton
            // 
            this.sendNotifyButton.BorderColor = System.Drawing.Color.Green;
            this.sendNotifyButton.BorderRadius = 10;
            this.sendNotifyButton.BorderThickness = 1;
            this.sendNotifyButton.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.sendNotifyButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendNotifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendNotifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendNotifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendNotifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendNotifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendNotifyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendNotifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendNotifyButton.ForeColor = System.Drawing.Color.White;
            this.sendNotifyButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sendNotifyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendNotifyButton.Location = new System.Drawing.Point(114, 221);
            this.sendNotifyButton.Name = "sendNotifyButton";
            this.sendNotifyButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.sendNotifyButton.Size = new System.Drawing.Size(97, 36);
            this.sendNotifyButton.TabIndex = 55;
            this.sendNotifyButton.Text = "Отправить";
            this.sendNotifyButton.Click += new System.EventHandler(this.sendNotifyButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.titleTextBox.BorderRadius = 10;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.DefaultText = "";
            this.titleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.titleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.titleTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.ForeColor = System.Drawing.Color.White;
            this.titleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.titleTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.titleTextBox.Location = new System.Drawing.Point(35, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.titleTextBox.PlaceholderText = "Заголовок";
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(176, 36);
            this.titleTextBox.TabIndex = 54;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationPanel.Controls.Add(this.closeButton);
            this.navigationPanel.Controls.Add(this.collapseButton);
            this.navigationPanel.Controls.Add(this.line);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(245, 30);
            this.navigationPanel.TabIndex = 53;
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Image = global::GameEnergy.Properties.Resources.close;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(215, 6);
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
            this.collapseButton.Location = new System.Drawing.Point(191, 6);
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
            this.line.Location = new System.Drawing.Point(3, 27);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(239, 3);
            this.line.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Animated = true;
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
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.descriptionTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(35, 136);
            this.descriptionTextBox.MaxLength = 600;
            this.descriptionTextBox.MinimumSize = new System.Drawing.Size(0, 66);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.descriptionTextBox.PlaceholderText = "Описание";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(176, 66);
            this.descriptionTextBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Новое уведомление";
            // 
            // WriteNotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(246, 286);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteNotifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriteNotifyForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormRounded;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox collapseButton;
        private Guna.UI2.WinForms.Guna2Button line;
        private Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        private Guna.UI2.WinForms.Guna2Button sendNotifyButton;
    }
}