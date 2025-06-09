namespace Activitatea_unui_restaurant
{
    partial class Form6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipăreșteGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.schimbăFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbăCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chenarGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chenarBareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genToolStripMenuItem,
            this.tipăreșteGraficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genToolStripMenuItem
            // 
            this.genToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.genToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genToolStripMenuItem.Name = "genToolStripMenuItem";
            this.genToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.genToolStripMenuItem.Text = "Generează grafic";
            this.genToolStripMenuItem.Click += new System.EventHandler(this.genToolStripMenuItem_Click);
            // 
            // tipăreșteGraficToolStripMenuItem
            // 
            this.tipăreșteGraficToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipăreșteGraficToolStripMenuItem.Name = "tipăreșteGraficToolStripMenuItem";
            this.tipăreșteGraficToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.tipăreșteGraficToolStripMenuItem.Text = "Tipărește grafic";
            this.tipăreșteGraficToolStripMenuItem.Click += new System.EventHandler(this.tipăreșteGraficToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbăFontToolStripMenuItem,
            this.schimbăCuloareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 423);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint);
            // 
            // schimbăFontToolStripMenuItem
            // 
            this.schimbăFontToolStripMenuItem.Name = "schimbăFontToolStripMenuItem";
            this.schimbăFontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.schimbăFontToolStripMenuItem.Text = "Schimbă font";
            this.schimbăFontToolStripMenuItem.Click += new System.EventHandler(this.schimbăFontToolStripMenuItem_Click);
            // 
            // schimbăCuloareToolStripMenuItem
            // 
            this.schimbăCuloareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chenarGraficToolStripMenuItem,
            this.chenarBareToolStripMenuItem,
            this.bareToolStripMenuItem,
            this.textToolStripMenuItem});
            this.schimbăCuloareToolStripMenuItem.Name = "schimbăCuloareToolStripMenuItem";
            this.schimbăCuloareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.schimbăCuloareToolStripMenuItem.Text = "Schimbă culoare";
            // 
            // chenarGraficToolStripMenuItem
            // 
            this.chenarGraficToolStripMenuItem.Name = "chenarGraficToolStripMenuItem";
            this.chenarGraficToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chenarGraficToolStripMenuItem.Text = "Chenar grafic";
            this.chenarGraficToolStripMenuItem.Click += new System.EventHandler(this.chenarGraficToolStripMenuItem_Click);
            // 
            // chenarBareToolStripMenuItem
            // 
            this.chenarBareToolStripMenuItem.Name = "chenarBareToolStripMenuItem";
            this.chenarBareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chenarBareToolStripMenuItem.Text = "Chenar bare";
            this.chenarBareToolStripMenuItem.Click += new System.EventHandler(this.chenarBareToolStripMenuItem_Click);
            // 
            // bareToolStripMenuItem
            // 
            this.bareToolStripMenuItem.Name = "bareToolStripMenuItem";
            this.bareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bareToolStripMenuItem.Text = "Bare";
            this.bareToolStripMenuItem.Click += new System.EventHandler(this.bareToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Form6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipăreșteGraficToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem schimbăFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbăCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chenarGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chenarBareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
    }
}