namespace GameEnergy.AppForms.UserForms
{
    partial class CartAndOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartAndOrderForm));
            this.navigationControl = new GameEnergy.CustomControls.NavigationControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.CartAndOrderTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.cart = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders = new System.Windows.Forms.TabPage();
            this.topSellersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grayLine = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartCountLabel = new System.Windows.Forms.Label();
            this.reviewPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.CartAndOrderTabControl.SuspendLayout();
            this.cart.SuspendLayout();
            this.orders.SuspendLayout();
            this.panel9.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.reviewPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.navigationControl.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.CartAndOrderTabControl);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(726, 378);
            this.mainPanel.TabIndex = 4;
            // 
            // CartAndOrderTabControl
            // 
            this.CartAndOrderTabControl.Controls.Add(this.cart);
            this.CartAndOrderTabControl.Controls.Add(this.orders);
            this.CartAndOrderTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartAndOrderTabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartAndOrderTabControl.ItemSize = new System.Drawing.Size(173, 40);
            this.CartAndOrderTabControl.Location = new System.Drawing.Point(100, 33);
            this.CartAndOrderTabControl.Name = "CartAndOrderTabControl";
            this.CartAndOrderTabControl.SelectedIndex = 0;
            this.CartAndOrderTabControl.Size = new System.Drawing.Size(526, 345);
            this.CartAndOrderTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.CartAndOrderTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(46)))));
            this.CartAndOrderTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CartAndOrderTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.CartAndOrderTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.CartAndOrderTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.CartAndOrderTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.CartAndOrderTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CartAndOrderTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.CartAndOrderTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CartAndOrderTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.CartAndOrderTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.CartAndOrderTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CartAndOrderTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.CartAndOrderTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.CartAndOrderTabControl.TabButtonSize = new System.Drawing.Size(173, 40);
            this.CartAndOrderTabControl.TabIndex = 34;
            this.CartAndOrderTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.CartAndOrderTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // cart
            // 
            this.cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cart.Controls.Add(this.panel9);
            this.cart.Controls.Add(this.panel8);
            this.cart.Controls.Add(this.cartPanel);
            this.cart.Controls.Add(this.panel7);
            this.cart.Controls.Add(this.panel6);
            this.cart.Controls.Add(this.panel3);
            this.cart.Controls.Add(this.panel2);
            this.cart.Location = new System.Drawing.Point(4, 44);
            this.cart.Name = "cart";
            this.cart.Padding = new System.Windows.Forms.Padding(3);
            this.cart.Size = new System.Drawing.Size(518, 297);
            this.cart.TabIndex = 0;
            this.cart.Text = "Корзина";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 35);
            this.panel2.TabIndex = 0;
            // 
            // orders
            // 
            this.orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.orders.Controls.Add(this.topSellersPanel);
            this.orders.Location = new System.Drawing.Point(4, 44);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(3);
            this.orders.Size = new System.Drawing.Size(518, 297);
            this.orders.TabIndex = 1;
            this.orders.Text = "Заказы";
            // 
            // topSellersPanel
            // 
            this.topSellersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topSellersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSellersPanel.Location = new System.Drawing.Point(3, 3);
            this.topSellersPanel.Name = "topSellersPanel";
            this.topSellersPanel.Size = new System.Drawing.Size(512, 291);
            this.topSellersPanel.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 33);
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
            // panel9
            // 
            this.panel9.Controls.Add(this.guna2Panel1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 143);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(512, 195);
            this.panel9.TabIndex = 67;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.payButton);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(512, 147);
            this.guna2Panel1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Вы будете перенаправлены на сайт платежной\r\nсистемы для завершения процедуры опла" +
    "ты.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.Black;
            this.payButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.payButton.BorderRadius = 8;
            this.payButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.payButton.ForeColor = System.Drawing.Color.Black;
            this.payButton.HoverState.FillColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(160, 100);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(177, 34);
            this.payButton.TabIndex = 20;
            this.payButton.Text = "ОПЛАТИТЬ 3490₽";
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "СИСТЕМА БЫСТРЫХ ПЛАТЕЖЕЙ";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(512, 16);
            this.panel10.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "ОПЛАТА ЗАКАЗА";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 119);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(512, 24);
            this.panel8.TabIndex = 66;
            // 
            // cartPanel
            // 
            this.cartPanel.AutoSize = true;
            this.cartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartPanel.Location = new System.Drawing.Point(3, 119);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(512, 0);
            this.cartPanel.TabIndex = 65;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 109);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(512, 10);
            this.panel7.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grayLine);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 11);
            this.panel6.TabIndex = 63;
            // 
            // grayLine
            // 
            this.grayLine.BackColor = System.Drawing.Color.Gray;
            this.grayLine.Location = new System.Drawing.Point(10, 10);
            this.grayLine.Name = "grayLine";
            this.grayLine.Size = new System.Drawing.Size(502, 1);
            this.grayLine.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cartCountLabel);
            this.panel3.Controls.Add(this.reviewPanel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 60);
            this.panel3.TabIndex = 62;
            // 
            // cartCountLabel
            // 
            this.cartCountLabel.AutoSize = true;
            this.cartCountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.cartCountLabel.Location = new System.Drawing.Point(168, 0);
            this.cartCountLabel.Name = "cartCountLabel";
            this.cartCountLabel.Size = new System.Drawing.Size(33, 37);
            this.cartCountLabel.TabIndex = 38;
            this.cartCountLabel.Text = "2";
            // 
            // reviewPanel
            // 
            this.reviewPanel.BorderColor = System.Drawing.Color.Gray;
            this.reviewPanel.BorderRadius = 10;
            this.reviewPanel.BorderThickness = 1;
            this.reviewPanel.Controls.Add(this.totalPriceLabel);
            this.reviewPanel.Controls.Add(this.label2);
            this.reviewPanel.FillColor = System.Drawing.Color.Black;
            this.reviewPanel.Location = new System.Drawing.Point(276, 0);
            this.reviewPanel.Name = "reviewPanel";
            this.reviewPanel.Size = new System.Drawing.Size(236, 52);
            this.reviewPanel.TabIndex = 37;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoEllipsis = true;
            this.totalPriceLabel.BackColor = System.Drawing.Color.Black;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(67)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(104, 8);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceLabel.Size = new System.Drawing.Size(129, 37);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИТОГО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "МОЙ ЗАКАЗ";
            // 
            // CartAndOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(726, 430);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CartAndOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.SizeChanged += new System.EventHandler(this.CartAndOrderForm_SizeChanged);
            this.Resize += new System.EventHandler(this.CartAndOrderForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.CartAndOrderTabControl.ResumeLayout(false);
            this.cart.ResumeLayout(false);
            this.cart.PerformLayout();
            this.orders.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.reviewPanel.ResumeLayout(false);
            this.reviewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.NavigationControl navigationControl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2TabControl CartAndOrderTabControl;
        private System.Windows.Forms.TabPage cart;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.FlowLayoutPanel topSellersPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel cartPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel grayLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cartCountLabel;
        private Guna.UI2.WinForms.Guna2Panel reviewPanel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}