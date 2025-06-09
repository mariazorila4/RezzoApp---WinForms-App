namespace Activitatea_unui_restaurant
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdaugareMeniu = new System.Windows.Forms.Button();
            this.ListaMeniuri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxNumeMeniu = new System.Windows.Forms.TextBox();
            this.textBoxPretMeniu = new System.Windows.Forms.TextBox();
            this.buttonVizualizareListaMeniuri = new System.Windows.Forms.Button();
            this.comboBoxTipMeniu = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1965, 68);
            this.label6.TabIndex = 15;
            this.label6.Text = "                                                        Meniuri                  " +
    "                                         ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(159, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nume meniu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(159, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tip meniu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(159, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Preț";
            // 
            // buttonAdaugareMeniu
            // 
            this.buttonAdaugareMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.buttonAdaugareMeniu.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugareMeniu.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdaugareMeniu.Location = new System.Drawing.Point(283, 772);
            this.buttonAdaugareMeniu.Name = "buttonAdaugareMeniu";
            this.buttonAdaugareMeniu.Size = new System.Drawing.Size(185, 129);
            this.buttonAdaugareMeniu.TabIndex = 23;
            this.buttonAdaugareMeniu.Text = "&Adaugă meniu";
            this.buttonAdaugareMeniu.UseVisualStyleBackColor = false;
            this.buttonAdaugareMeniu.Click += new System.EventHandler(this.buttonAdaugareMeniu_Click);
            // 
            // ListaMeniuri
            // 
            this.ListaMeniuri.ContextMenuStrip = this.contextMenuStrip1;
            this.ListaMeniuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaMeniuri.FormattingEnabled = true;
            this.ListaMeniuri.ItemHeight = 20;
            this.ListaMeniuri.Location = new System.Drawing.Point(140, 67);
            this.ListaMeniuri.Name = "ListaMeniuri";
            this.ListaMeniuri.Size = new System.Drawing.Size(801, 624);
            this.ListaMeniuri.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 52);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.jSONToolStripMenuItem1_Click);
            // 
            // textBoxNumeMeniu
            // 
            this.textBoxNumeMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumeMeniu.Location = new System.Drawing.Point(302, 219);
            this.textBoxNumeMeniu.Name = "textBoxNumeMeniu";
            this.textBoxNumeMeniu.Size = new System.Drawing.Size(342, 27);
            this.textBoxNumeMeniu.TabIndex = 28;
            // 
            // textBoxPretMeniu
            // 
            this.textBoxPretMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPretMeniu.Location = new System.Drawing.Point(302, 543);
            this.textBoxPretMeniu.Name = "textBoxPretMeniu";
            this.textBoxPretMeniu.Size = new System.Drawing.Size(342, 27);
            this.textBoxPretMeniu.TabIndex = 30;
            // 
            // buttonVizualizareListaMeniuri
            // 
            this.buttonVizualizareListaMeniuri.BackColor = System.Drawing.Color.Bisque;
            this.buttonVizualizareListaMeniuri.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVizualizareListaMeniuri.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVizualizareListaMeniuri.Location = new System.Drawing.Point(388, 772);
            this.buttonVizualizareListaMeniuri.Name = "buttonVizualizareListaMeniuri";
            this.buttonVizualizareListaMeniuri.Size = new System.Drawing.Size(297, 129);
            this.buttonVizualizareListaMeniuri.TabIndex = 36;
            this.buttonVizualizareListaMeniuri.Text = "&Vizualizează lista cu meniuri";
            this.buttonVizualizareListaMeniuri.UseVisualStyleBackColor = false;
            this.buttonVizualizareListaMeniuri.Click += new System.EventHandler(this.buttonVizualizareListaMeniuri_Click);
            // 
            // comboBoxTipMeniu
            // 
            this.comboBoxTipMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTipMeniu.FormattingEnabled = true;
            this.comboBoxTipMeniu.Location = new System.Drawing.Point(302, 385);
            this.comboBoxTipMeniu.Name = "comboBoxTipMeniu";
            this.comboBoxTipMeniu.Size = new System.Drawing.Size(342, 26);
            this.comboBoxTipMeniu.TabIndex = 37;
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
            this.panel1.Controls.Add(this.buttonVizualizareListaMeniuri);
            this.panel1.Controls.Add(this.ListaMeniuri);
            this.panel1.Location = new System.Drawing.Point(827, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 968);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.comboBoxTipMeniu);
            this.panel2.Controls.Add(this.textBoxPretMeniu);
            this.panel2.Controls.Add(this.textBoxNumeMeniu);
            this.panel2.Controls.Add(this.buttonAdaugareMeniu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 968);
            this.panel2.TabIndex = 39;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(129)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Meniuri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdaugareMeniu;
        private System.Windows.Forms.ListBox ListaMeniuri;
        private System.Windows.Forms.TextBox textBoxNumeMeniu;
        private System.Windows.Forms.TextBox textBoxPretMeniu;
        private System.Windows.Forms.Button buttonVizualizareListaMeniuri;
        private System.Windows.Forms.ComboBox comboBoxTipMeniu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}