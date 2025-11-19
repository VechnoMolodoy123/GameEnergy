namespace GameEnergy.AppForms.UserForms
{
    partial class GameInfoForm
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
            this.trailerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trailerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trailerPictureBox
            // 
            this.trailerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trailerPictureBox.Location = new System.Drawing.Point(240, 135);
            this.trailerPictureBox.Name = "trailerPictureBox";
            this.trailerPictureBox.Size = new System.Drawing.Size(320, 180);
            this.trailerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trailerPictureBox.TabIndex = 1;
            this.trailerPictureBox.TabStop = false;
            // 
            // GameInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trailerPictureBox);
            this.Name = "GameInfoForm";
            this.Text = "GameInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.trailerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trailerPictureBox;
    }
}