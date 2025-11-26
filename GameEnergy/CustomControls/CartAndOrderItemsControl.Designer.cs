namespace GameEnergy.CustomControls
{
    partial class CartAndOrderItemsControl
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
            this.gameImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.PictureBox();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // gameImage
            // 
            this.gameImage.BackColor = System.Drawing.Color.Transparent;
            this.gameImage.BorderRadius = 13;
            this.gameImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameImage.Image = global::GameEnergy.Properties.Resources.DefaultGameImage;
            this.gameImage.ImageRotate = 0F;
            this.gameImage.Location = new System.Drawing.Point(0, 0);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(105, 130);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImage.TabIndex = 10;
            this.gameImage.TabStop = false;
            this.gameImage.Click += new System.EventHandler(this.gameImage_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(122, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(341, 50);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Название";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(123, 83);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(78, 25);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "3999 ₽";
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = global::GameEnergy.Properties.Resources.close;
            this.deleteButton.Location = new System.Drawing.Point(477, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 23);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteButton.TabIndex = 14;
            this.deleteButton.TabStop = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.AutoSize = true;
            this.oldPriceLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.oldPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPriceLabel.ForeColor = System.Drawing.Color.Gray;
            this.oldPriceLabel.Location = new System.Drawing.Point(207, 83);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(78, 25);
            this.oldPriceLabel.TabIndex = 18;
            this.oldPriceLabel.Text = "3999 ₽";
            this.oldPriceLabel.Visible = false;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountLabel.Location = new System.Drawing.Point(291, 83);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(62, 25);
            this.discountLabel.TabIndex = 17;
            this.discountLabel.Text = "-50%";
            this.discountLabel.Visible = false;
            // 
            // CartAndOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.oldPriceLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameImage);
            this.Name = "CartAndOrderControl";
            this.Size = new System.Drawing.Size(500, 130);
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gameImage;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox deleteButton;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Label discountLabel;
    }
}
