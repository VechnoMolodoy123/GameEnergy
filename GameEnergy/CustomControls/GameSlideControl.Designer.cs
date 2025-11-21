namespace GameEnergy.CustomControls
{
    partial class GameSlideControl
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.gameImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoEllipsis = true;
            this.headerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(4, 4);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(173, 87);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "ОБЪЕДИНЯЙТЕСЬ С ВЫЖИВШИМИ В ARC RAIDERS";
            this.headerLabel.Click += new System.EventHandler(this.GameSlideControl_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoEllipsis = true;
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(4, 91);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(86, 21);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "3999 ₽";
            this.priceLabel.Click += new System.EventHandler(this.GameSlideControl_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoEllipsis = true;
            this.discountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountLabel.Location = new System.Drawing.Point(134, 94);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(46, 16);
            this.discountLabel.TabIndex = 2;
            this.discountLabel.Text = "-99%";
            this.discountLabel.Click += new System.EventHandler(this.GameSlideControl_Click);
            // 
            // gameImage
            // 
            this.gameImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gameImage.BorderRadius = 10;
            this.gameImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameImage.Image = global::GameEnergy.Properties.Resources.ARC_RaidersSlide;
            this.gameImage.ImageRotate = 0F;
            this.gameImage.Location = new System.Drawing.Point(0, 120);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(180, 100);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImage.TabIndex = 4;
            this.gameImage.TabStop = false;
            this.gameImage.Click += new System.EventHandler(this.GameSlideControl_Click);
            // 
            // GameSlideControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.gameImage);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.headerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GameSlideControl";
            this.Size = new System.Drawing.Size(180, 220);
            this.Click += new System.EventHandler(this.GameSlideControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label discountLabel;
        private Guna.UI2.WinForms.Guna2PictureBox gameImage;
    }
}
