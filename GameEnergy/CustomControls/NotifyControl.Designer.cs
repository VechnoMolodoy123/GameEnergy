namespace GameEnergy.CustomControls
{
    partial class NotifyControl
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.copyMailButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gameLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mainPanel.BorderColor = System.Drawing.Color.Silver;
            this.mainPanel.BorderRadius = 10;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(526, 157);
            this.mainPanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.messageLabel);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(110, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 126);
            this.panel4.TabIndex = 15;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(0, 52);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(239, 64);
            this.messageLabel.TabIndex = 20;
            this.messageLabel.Text = "Сообщение";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.copyMailButton);
            this.panel8.Controls.Add(this.deleteButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(239, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 85);
            this.panel8.TabIndex = 19;
            // 
            // copyMailButton
            // 
            this.copyMailButton.BorderColor = System.Drawing.Color.Green;
            this.copyMailButton.BorderRadius = 10;
            this.copyMailButton.BorderThickness = 1;
            this.copyMailButton.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.copyMailButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.copyMailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyMailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyMailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyMailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyMailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyMailButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.copyMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyMailButton.ForeColor = System.Drawing.Color.Black;
            this.copyMailButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.copyMailButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.copyMailButton.Location = new System.Drawing.Point(10, 8);
            this.copyMailButton.Name = "copyMailButton";
            this.copyMailButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.copyMailButton.Size = new System.Drawing.Size(158, 38);
            this.copyMailButton.TabIndex = 54;
            this.copyMailButton.Text = "Скопировать почту";
            this.copyMailButton.Visible = false;
            this.copyMailButton.Click += new System.EventHandler(this.copyMailButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.BorderColor = System.Drawing.Color.Red;
            this.deleteButton.BorderRadius = 8;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.HoverState.FillColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(54, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 30);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 10);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gameLabel);
            this.panel6.Controls.Add(this.titlePanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 31);
            this.panel6.TabIndex = 18;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoEllipsis = true;
            this.gameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameLabel.ForeColor = System.Drawing.Color.White;
            this.gameLabel.Location = new System.Drawing.Point(130, 15);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(286, 16);
            this.gameLabel.TabIndex = 18;
            this.gameLabel.Text = "Игра";
            this.gameLabel.Click += new System.EventHandler(this.gameLabel_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(130, 31);
            this.titlePanel.TabIndex = 17;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(1, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(130, 16);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Жалоба на игру:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(110, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 31);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Controls.Add(this.senderLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 31);
            this.panel3.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(137, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 16);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Имя";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // senderLabel
            // 
            this.senderLabel.AutoEllipsis = true;
            this.senderLabel.AutoSize = true;
            this.senderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.senderLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.senderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.senderLabel.ForeColor = System.Drawing.Color.White;
            this.senderLabel.Location = new System.Drawing.Point(54, 12);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(84, 16);
            this.senderLabel.TabIndex = 15;
            this.senderLabel.Text = "Отправил:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(6, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 16);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Дата";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.avatarPictureBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 157);
            this.panel1.TabIndex = 13;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.avatarPictureBox.BorderRadius = 6;
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.avatarPictureBox.Image = global::GameEnergy.Properties.Resources.Complaint;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(24, 44);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(70, 70);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 1;
            this.avatarPictureBox.TabStop = false;
            // 
            // NotifyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "NotifyControl";
            this.Size = new System.Drawing.Size(526, 157);
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button copyMailButton;
    }
}
