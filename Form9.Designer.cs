namespace Activitatea_unui_restaurant
{
    partial class Form9
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
            this.ucLoginBazaDate1 = new Activitatea_unui_restaurant.UCLoginBazaDate();
            this.SuspendLayout();
            // 
            // ucLoginBazaDate1
            // 
            this.ucLoginBazaDate1.BackColor = System.Drawing.Color.Thistle;
            this.ucLoginBazaDate1.Location = new System.Drawing.Point(1, 0);
            this.ucLoginBazaDate1.Name = "ucLoginBazaDate1";
            this.ucLoginBazaDate1.Size = new System.Drawing.Size(290, 291);
            this.ucLoginBazaDate1.TabIndex = 0;
            this.ucLoginBazaDate1.btngoClicked += new System.EventHandler(this.goClicked);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 294);
            this.Controls.Add(this.ucLoginBazaDate1);
            this.Name = "Form9";
            this.Text = "Log In";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLoginBazaDate ucLoginBazaDate1;
    }
}