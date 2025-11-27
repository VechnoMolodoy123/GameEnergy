namespace GameEnergy.CustomControls
{
    partial class OrderControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 10);
            this.panel3.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 67);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(500, 1);
            this.panel11.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.orderNumberLabel);
            this.panel4.Controls.Add(this.totalAmountLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 66);
            this.panel4.TabIndex = 18;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoEllipsis = true;
            this.orderNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNumberLabel.ForeColor = System.Drawing.Color.White;
            this.orderNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(271, 66);
            this.orderNumberLabel.TabIndex = 16;
            this.orderNumberLabel.Text = "№574765 - 17.08.2021";
            this.orderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoEllipsis = true;
            this.totalAmountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.totalAmountLabel.Location = new System.Drawing.Point(271, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(229, 66);
            this.totalAmountLabel.TabIndex = 15;
            this.totalAmountLabel.Text = "1500";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoSize = true;
            this.itemsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemsPanel.Location = new System.Drawing.Point(0, 78);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(500, 0);
            this.itemsPanel.TabIndex = 57;
            this.itemsPanel.WrapContents = false;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 80);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(500, 80);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
    }
}
