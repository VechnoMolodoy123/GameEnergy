namespace GameEnergy.CustomControls
{
    partial class UserCommentsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCommentsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.likesCountLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.commentLabel = new System.Windows.Forms.Label();
            this.likesButton = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.avatarPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.avatarPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 130);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.likesButton);
            this.panel2.Controls.Add(this.likesCountLabel);
            this.panel2.Controls.Add(this.star5);
            this.panel2.Controls.Add(this.star4);
            this.panel2.Controls.Add(this.star3);
            this.panel2.Controls.Add(this.star2);
            this.panel2.Controls.Add(this.star1);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 40);
            this.panel2.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.nameLabel.Location = new System.Drawing.Point(7, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(189, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Никнейм";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.Silver;
            this.dateLabel.Location = new System.Drawing.Point(8, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(37, 15);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Дата";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // likesCountLabel
            // 
            this.likesCountLabel.AutoSize = true;
            this.likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likesCountLabel.ForeColor = System.Drawing.Color.White;
            this.likesCountLabel.Location = new System.Drawing.Point(442, 9);
            this.likesCountLabel.Name = "likesCountLabel";
            this.likesCountLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.likesCountLabel.Size = new System.Drawing.Size(21, 18);
            this.likesCountLabel.TabIndex = 18;
            this.likesCountLabel.Text = "10";
            this.likesCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.panel7);
            this.descriptionPanel.Controls.Add(this.panel6);
            this.descriptionPanel.Controls.Add(this.panel5);
            this.descriptionPanel.Controls.Add(this.panel4);
            this.descriptionPanel.Controls.Add(this.panel3);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionPanel.Location = new System.Drawing.Point(50, 40);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(476, 90);
            this.descriptionPanel.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 10);
            this.panel6.TabIndex = 75;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(466, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 67);
            this.panel5.TabIndex = 74;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 67);
            this.panel4.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 23);
            this.panel3.TabIndex = 72;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.commentLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 23);
            this.panel7.MinimumSize = new System.Drawing.Size(0, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 16);
            this.panel7.TabIndex = 76;
            // 
            // commentLabel
            // 
            this.commentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(0, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(456, 16);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Комментарий";
            this.commentLabel.TextChanged += new System.EventHandler(this.commentLabel_TextChanged);
            // 
            // likesButton
            // 
            this.likesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likesButton.Image = global::GameEnergy.Properties.Resources.whiteLike;
            this.likesButton.Location = new System.Drawing.Point(419, 9);
            this.likesButton.Name = "likesButton";
            this.likesButton.Size = new System.Drawing.Size(20, 20);
            this.likesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesButton.TabIndex = 19;
            this.likesButton.TabStop = false;
            this.likesButton.Click += new System.EventHandler(this.likesButton_Click);
            // 
            // star5
            // 
            this.star5.Cursor = System.Windows.Forms.Cursors.Default;
            this.star5.Image = global::GameEnergy.Properties.Resources.star;
            this.star5.Location = new System.Drawing.Point(329, 9);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(20, 20);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 17;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Cursor = System.Windows.Forms.Cursors.Default;
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(298, 9);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(20, 20);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 16;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Cursor = System.Windows.Forms.Cursors.Default;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(267, 9);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(20, 20);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 15;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Cursor = System.Windows.Forms.Cursors.Default;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(236, 9);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(20, 20);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 14;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Cursor = System.Windows.Forms.Cursors.Default;
            this.star1.Image = global::GameEnergy.Properties.Resources.star;
            this.star1.Location = new System.Drawing.Point(206, 9);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(20, 20);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 13;
            this.star1.TabStop = false;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.ImageRotate = 0F;
            this.avatarPictureBox.Location = new System.Drawing.Point(0, 0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatarPictureBox.Size = new System.Drawing.Size(40, 40);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // UserCommentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserCommentsControl";
            this.Size = new System.Drawing.Size(526, 130);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.likesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox likesButton;
        private System.Windows.Forms.Label likesCountLabel;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}
