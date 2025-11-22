namespace GameEnergy.CustomControls
{
    partial class MainGameControl
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gameImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 11;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.discountLabel);
            this.guna2Panel1.Controls.Add(this.costLabel);
            this.guna2Panel1.Controls.Add(this.titleLabel);
            this.guna2Panel1.Controls.Add(this.gameImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(146, 270);
            this.guna2Panel1.TabIndex = 0;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.discountLabel.Location = new System.Drawing.Point(106, 245);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(37, 16);
            this.discountLabel.TabIndex = 13;
            this.discountLabel.Text = "-50%";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.White;
            this.costLabel.Location = new System.Drawing.Point(3, 245);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(45, 16);
            this.costLabel.TabIndex = 12;
            this.costLabel.Text = "3999 ₽";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 189);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(140, 50);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Название";
            // 
            // gameImage
            // 
            this.gameImage.BackColor = System.Drawing.Color.Transparent;
            this.gameImage.BorderRadius = 13;
            this.gameImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameImage.Image = global::GameEnergy.Properties.Resources.DefaultGameImage;
            this.gameImage.ImageRotate = 0F;
            this.gameImage.Location = new System.Drawing.Point(0, 0);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(146, 182);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImage.TabIndex = 9;
            this.gameImage.TabStop = false;
            // 
            // HitGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "HitGameControl";
            this.Size = new System.Drawing.Size(146, 270);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox gameImage;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label discountLabel;
    }
}
