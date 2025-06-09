namespace Activitatea_unui_restaurant
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdaugareOspatar = new System.Windows.Forms.Button();
            this.textBoxIdOspatar = new System.Windows.Forms.TextBox();
            this.textBoxNumeOspatar = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeOspatar = new System.Windows.Forms.TextBox();
            this.comboBoxTura = new System.Windows.Forms.ComboBox();
            this.ListaOspatari = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVizualizareListaOspatari = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "                                                  Ospătari                       " +
    "                                      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(58, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID ospătar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(58, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(58, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prenume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(58, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tura";
            // 
            // buttonAdaugareOspatar
            // 
            this.buttonAdaugareOspatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.buttonAdaugareOspatar.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugareOspatar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdaugareOspatar.Location = new System.Drawing.Point(270, 780);
            this.buttonAdaugareOspatar.Name = "buttonAdaugareOspatar";
            this.buttonAdaugareOspatar.Size = new System.Drawing.Size(248, 134);
            this.buttonAdaugareOspatar.TabIndex = 6;
            this.buttonAdaugareOspatar.Text = "&Adaugă ospătarul";
            this.buttonAdaugareOspatar.UseVisualStyleBackColor = false;
            this.buttonAdaugareOspatar.Click += new System.EventHandler(this.buttonAdaugareOspatar_Click);
            // 
            // textBoxIdOspatar
            // 
            this.textBoxIdOspatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdOspatar.Location = new System.Drawing.Point(177, 210);
            this.textBoxIdOspatar.Name = "textBoxIdOspatar";
            this.textBoxIdOspatar.Size = new System.Drawing.Size(554, 27);
            this.textBoxIdOspatar.TabIndex = 7;
            // 
            // textBoxNumeOspatar
            // 
            this.textBoxNumeOspatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumeOspatar.Location = new System.Drawing.Point(177, 331);
            this.textBoxNumeOspatar.Name = "textBoxNumeOspatar";
            this.textBoxNumeOspatar.Size = new System.Drawing.Size(554, 27);
            this.textBoxNumeOspatar.TabIndex = 8;
            // 
            // textBoxPrenumeOspatar
            // 
            this.textBoxPrenumeOspatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrenumeOspatar.Location = new System.Drawing.Point(177, 466);
            this.textBoxPrenumeOspatar.Name = "textBoxPrenumeOspatar";
            this.textBoxPrenumeOspatar.Size = new System.Drawing.Size(554, 27);
            this.textBoxPrenumeOspatar.TabIndex = 9;
            // 
            // comboBoxTura
            // 
            this.comboBoxTura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTura.FormattingEnabled = true;
            this.comboBoxTura.Items.AddRange(new object[] {
            "Dimineata (10:00 - 14:00)",
            "DupaAmiaza (14:00 - 18:00)",
            "Seara (18:00 - 22:00)"});
            this.comboBoxTura.Location = new System.Drawing.Point(177, 584);
            this.comboBoxTura.Name = "comboBoxTura";
            this.comboBoxTura.Size = new System.Drawing.Size(554, 26);
            this.comboBoxTura.TabIndex = 13;
            // 
            // ListaOspatari
            // 
            this.ListaOspatari.ContextMenuStrip = this.contextMenuStrip1;
            this.ListaOspatari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaOspatari.FormattingEnabled = true;
            this.ListaOspatari.ItemHeight = 20;
            this.ListaOspatari.Location = new System.Drawing.Point(114, 70);
            this.ListaOspatari.Name = "ListaOspatari";
            this.ListaOspatari.Size = new System.Drawing.Size(864, 564);
            this.ListaOspatari.TabIndex = 14;
            this.ListaOspatari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListaOspatari_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 52);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.salveazaToolStripMenuItem.Text = "Serialize";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem1});
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.stergeToolStripMenuItem.Text = "Deserialize";
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.jSONToolStripMenuItem1_Click);
            // 
            // buttonVizualizareListaOspatari
            // 
            this.buttonVizualizareListaOspatari.BackColor = System.Drawing.Color.Bisque;
            this.buttonVizualizareListaOspatari.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonVizualizareListaOspatari.FlatAppearance.BorderSize = 10;
            this.buttonVizualizareListaOspatari.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVizualizareListaOspatari.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVizualizareListaOspatari.Location = new System.Drawing.Point(382, 669);
            this.buttonVizualizareListaOspatari.Name = "buttonVizualizareListaOspatari";
            this.buttonVizualizareListaOspatari.Size = new System.Drawing.Size(317, 134);
            this.buttonVizualizareListaOspatari.TabIndex = 15;
            this.buttonVizualizareListaOspatari.Text = "&Vizualizează lista cu ospătari";
            this.buttonVizualizareListaOspatari.UseVisualStyleBackColor = false;
            this.buttonVizualizareListaOspatari.Click += new System.EventHandler(this.buttonVizualizareListaOspatari_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Controls.Add(this.buttonVizualizareListaOspatari);
            this.panel1.Controls.Add(this.ListaOspatari);
            this.panel1.Location = new System.Drawing.Point(824, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 970);
            this.panel1.TabIndex = 16;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHelp.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHelp.Location = new System.Drawing.Point(69, 692);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(122, 95);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Indicații Top 3 ospătari";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelTop
            // 
            this.panelTop.AllowDrop = true;
            this.panelTop.BackColor = System.Drawing.Color.MistyRose;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Location = new System.Drawing.Point(195, 841);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(717, 126);
            this.panelTop.TabIndex = 16;
            this.panelTop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTopDragDrop);
            this.panelTop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTopDragEnter);
            this.panelTop.DragLeave += new System.EventHandler(this.panelTopDragLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(180, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Top 3 ospătari selectați pentru promovare";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.comboBoxTura);
            this.panel2.Controls.Add(this.textBoxPrenumeOspatar);
            this.panel2.Controls.Add(this.textBoxNumeOspatar);
            this.panel2.Controls.Add(this.textBoxIdOspatar);
            this.panel2.Controls.Add(this.buttonAdaugareOspatar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 973);
            this.panel2.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(129)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ospatari";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdaugareOspatar;
        private System.Windows.Forms.TextBox textBoxIdOspatar;
        private System.Windows.Forms.TextBox textBoxNumeOspatar;
        private System.Windows.Forms.TextBox textBoxPrenumeOspatar;
        private System.Windows.Forms.ComboBox comboBoxTura;
        private System.Windows.Forms.ListBox ListaOspatari;
        private System.Windows.Forms.Button buttonVizualizareListaOspatari;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelp;
    }
}