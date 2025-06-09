namespace Activitatea_unui_restaurant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdaugareRezervare = new System.Windows.Forms.Button();
            this.textBoxIdRezervare = new System.Windows.Forms.TextBox();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownNumarPersoaneRezervare = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMasaDisponibilaPtRezervare = new System.Windows.Forms.ComboBox();
            this.comboBoxOspatarDisponibilPtRezervare = new System.Windows.Forms.ComboBox();
            this.IstoricRezervari = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVizualizareIstoricRezervari = new System.Windows.Forms.Button();
            this.buttonAccesOspatari = new System.Windows.Forms.Button();
            this.buttonAccesMese = new System.Windows.Forms.Button();
            this.buttonAccesMeniuri = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelpInstructiuni = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRezervareSelectata = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareGraficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficRezervăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficOspătariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficMeseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumarPersoaneRezervare)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(20, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 45);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rezervări";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(45, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID rezervare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(45, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nume client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(45, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data și ora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(45, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Număr persoane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(45, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Masa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(15)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(45, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ospătar";
            // 
            // buttonAdaugareRezervare
            // 
            this.buttonAdaugareRezervare.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAdaugareRezervare.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugareRezervare.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdaugareRezervare.Location = new System.Drawing.Point(325, 696);
            this.buttonAdaugareRezervare.Name = "buttonAdaugareRezervare";
            this.buttonAdaugareRezervare.Size = new System.Drawing.Size(234, 114);
            this.buttonAdaugareRezervare.TabIndex = 21;
            this.buttonAdaugareRezervare.Text = "&Adaugă rezervarea";
            this.buttonAdaugareRezervare.UseVisualStyleBackColor = false;
            this.buttonAdaugareRezervare.Click += new System.EventHandler(this.buttonAdaugareRezervare_Click);
            // 
            // textBoxIdRezervare
            // 
            this.textBoxIdRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdRezervare.Location = new System.Drawing.Point(245, 174);
            this.textBoxIdRezervare.Name = "textBoxIdRezervare";
            this.textBoxIdRezervare.Size = new System.Drawing.Size(611, 27);
            this.textBoxIdRezervare.TabIndex = 24;
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumeClient.Location = new System.Drawing.Point(245, 250);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(611, 27);
            this.textBoxNumeClient.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 325);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 4, 13, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(611, 27);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // numericUpDownNumarPersoaneRezervare
            // 
            this.numericUpDownNumarPersoaneRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownNumarPersoaneRezervare.Location = new System.Drawing.Point(245, 401);
            this.numericUpDownNumarPersoaneRezervare.Name = "numericUpDownNumarPersoaneRezervare";
            this.numericUpDownNumarPersoaneRezervare.Size = new System.Drawing.Size(611, 27);
            this.numericUpDownNumarPersoaneRezervare.TabIndex = 34;
            // 
            // comboBoxMasaDisponibilaPtRezervare
            // 
            this.comboBoxMasaDisponibilaPtRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMasaDisponibilaPtRezervare.FormattingEnabled = true;
            this.comboBoxMasaDisponibilaPtRezervare.Location = new System.Drawing.Point(245, 476);
            this.comboBoxMasaDisponibilaPtRezervare.Name = "comboBoxMasaDisponibilaPtRezervare";
            this.comboBoxMasaDisponibilaPtRezervare.Size = new System.Drawing.Size(611, 26);
            this.comboBoxMasaDisponibilaPtRezervare.TabIndex = 35;
            // 
            // comboBoxOspatarDisponibilPtRezervare
            // 
            this.comboBoxOspatarDisponibilPtRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOspatarDisponibilPtRezervare.FormattingEnabled = true;
            this.comboBoxOspatarDisponibilPtRezervare.Location = new System.Drawing.Point(245, 552);
            this.comboBoxOspatarDisponibilPtRezervare.Name = "comboBoxOspatarDisponibilPtRezervare";
            this.comboBoxOspatarDisponibilPtRezervare.Size = new System.Drawing.Size(611, 26);
            this.comboBoxOspatarDisponibilPtRezervare.TabIndex = 36;
            // 
            // IstoricRezervari
            // 
            this.IstoricRezervari.AllowDrop = true;
            this.IstoricRezervari.ContextMenuStrip = this.contextMenuStrip1;
            this.IstoricRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IstoricRezervari.FormattingEnabled = true;
            this.IstoricRezervari.ItemHeight = 16;
            this.IstoricRezervari.Location = new System.Drawing.Point(33, 96);
            this.IstoricRezervari.Name = "IstoricRezervari";
            this.IstoricRezervari.Size = new System.Drawing.Size(981, 436);
            this.IstoricRezervari.TabIndex = 37;
            this.IstoricRezervari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IstoricRezervari_MouseDown);
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
            // buttonVizualizareIstoricRezervari
            // 
            this.buttonVizualizareIstoricRezervari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.buttonVizualizareIstoricRezervari.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVizualizareIstoricRezervari.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVizualizareIstoricRezervari.Location = new System.Drawing.Point(358, 555);
            this.buttonVizualizareIstoricRezervari.Name = "buttonVizualizareIstoricRezervari";
            this.buttonVizualizareIstoricRezervari.Size = new System.Drawing.Size(323, 108);
            this.buttonVizualizareIstoricRezervari.TabIndex = 38;
            this.buttonVizualizareIstoricRezervari.Text = "&Vizualizează istoric rezervări";
            this.buttonVizualizareIstoricRezervari.UseVisualStyleBackColor = false;
            this.buttonVizualizareIstoricRezervari.Click += new System.EventHandler(this.buttonVizualizareIstoricRezervari_Click);
            // 
            // buttonAccesOspatari
            // 
            this.buttonAccesOspatari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAccesOspatari.BackColor = System.Drawing.Color.Bisque;
            this.buttonAccesOspatari.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccesOspatari.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.buttonAccesOspatari.Location = new System.Drawing.Point(244, 46);
            this.buttonAccesOspatari.Name = "buttonAccesOspatari";
            this.buttonAccesOspatari.Size = new System.Drawing.Size(277, 84);
            this.buttonAccesOspatari.TabIndex = 39;
            this.buttonAccesOspatari.Text = "Editează ospătari";
            this.buttonAccesOspatari.UseVisualStyleBackColor = false;
            this.buttonAccesOspatari.Click += new System.EventHandler(this.buttonAccesOspatari_Click);
            // 
            // buttonAccesMese
            // 
            this.buttonAccesMese.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAccesMese.BackColor = System.Drawing.Color.Bisque;
            this.buttonAccesMese.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccesMese.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.buttonAccesMese.Location = new System.Drawing.Point(776, 46);
            this.buttonAccesMese.Name = "buttonAccesMese";
            this.buttonAccesMese.Size = new System.Drawing.Size(274, 84);
            this.buttonAccesMese.TabIndex = 40;
            this.buttonAccesMese.Text = "Editează mese";
            this.buttonAccesMese.UseVisualStyleBackColor = false;
            this.buttonAccesMese.Click += new System.EventHandler(this.buttonAccesMese_Click);
            // 
            // buttonAccesMeniuri
            // 
            this.buttonAccesMeniuri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccesMeniuri.BackColor = System.Drawing.Color.Bisque;
            this.buttonAccesMeniuri.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccesMeniuri.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.buttonAccesMeniuri.Location = new System.Drawing.Point(1335, 46);
            this.buttonAccesMeniuri.Name = "buttonAccesMeniuri";
            this.buttonAccesMeniuri.Size = new System.Drawing.Size(274, 96);
            this.buttonAccesMeniuri.TabIndex = 41;
            this.buttonAccesMeniuri.Text = "Editează meniuri";
            this.buttonAccesMeniuri.UseVisualStyleBackColor = false;
            this.buttonAccesMeniuri.Click += new System.EventHandler(this.buttonAccesMeniuri_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.buttonHelpInstructiuni);
            this.panel1.Controls.Add(this.comboBoxOspatarDisponibilPtRezervare);
            this.panel1.Controls.Add(this.comboBoxMasaDisponibilaPtRezervare);
            this.panel1.Controls.Add(this.numericUpDownNumarPersoaneRezervare);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBoxNumeClient);
            this.panel1.Controls.Add(this.textBoxIdRezervare);
            this.panel1.Controls.Add(this.buttonAdaugareRezervare);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 841);
            this.panel1.TabIndex = 42;
            // 
            // buttonHelpInstructiuni
            // 
            this.buttonHelpInstructiuni.BackColor = System.Drawing.Color.Salmon;
            this.buttonHelpInstructiuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHelpInstructiuni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonHelpInstructiuni.Location = new System.Drawing.Point(24, 720);
            this.buttonHelpInstructiuni.Name = "buttonHelpInstructiuni";
            this.buttonHelpInstructiuni.Size = new System.Drawing.Size(151, 75);
            this.buttonHelpInstructiuni.TabIndex = 37;
            this.buttonHelpInstructiuni.Text = "HELP!! Am nevoie de instructiuni :)";
            this.buttonHelpInstructiuni.UseVisualStyleBackColor = false;
            this.buttonHelpInstructiuni.Click += new System.EventHandler(this.buttonHelpInstructiuni_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonVizualizareIstoricRezervari);
            this.panel2.Controls.Add(this.IstoricRezervari);
            this.panel2.Location = new System.Drawing.Point(861, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 844);
            this.panel2.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(-6, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1935, 68);
            this.label5.TabIndex = 44;
            this.label5.Text = "                                                 Restaurant                      " +
    "                                     ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel3.Controls.Add(this.lblRezervareSelectata);
            this.panel3.Controls.Add(this.buttonAccesMeniuri);
            this.panel3.Controls.Add(this.buttonAccesMese);
            this.panel3.Controls.Add(this.buttonAccesOspatari);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 834);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1902, 199);
            this.panel3.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button1.Location = new System.Drawing.Point(753, 754);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 59);
            this.button1.TabIndex = 43;
            this.button1.Text = "Acces bază de date";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRezervareSelectata
            // 
            this.lblRezervareSelectata.AllowDrop = true;
            this.lblRezervareSelectata.AutoSize = true;
            this.lblRezervareSelectata.BackColor = System.Drawing.Color.MistyRose;
            this.lblRezervareSelectata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRezervareSelectata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezervareSelectata.Location = new System.Drawing.Point(60, 158);
            this.lblRezervareSelectata.Name = "lblRezervareSelectata";
            this.lblRezervareSelectata.Size = new System.Drawing.Size(587, 18);
            this.lblRezervareSelectata.TabIndex = 39;
            this.lblRezervareSelectata.Text = "Trage aici rezervarea selectată din istoricul rezervărilor pentru a putea să o vi" +
    "zualizezi mai detaliat";
            this.lblRezervareSelectata.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDragDrop);
            this.lblRezervareSelectata.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDragEnter);
            this.lblRezervareSelectata.DragOver += new System.Windows.Forms.DragEventHandler(this.lblDragOver);
            this.lblRezervareSelectata.DragLeave += new System.EventHandler(this.lblDragLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareGraficeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 30);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareGraficeToolStripMenuItem
            // 
            this.vizualizareGraficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficRezervăriToolStripMenuItem,
            this.graficOspătariToolStripMenuItem,
            this.graficMeseToolStripMenuItem});
            this.vizualizareGraficeToolStripMenuItem.Name = "vizualizareGraficeToolStripMenuItem";
            this.vizualizareGraficeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.vizualizareGraficeToolStripMenuItem.Text = "Vizualizare grafice";
            // 
            // graficRezervăriToolStripMenuItem
            // 
            this.graficRezervăriToolStripMenuItem.Name = "graficRezervăriToolStripMenuItem";
            this.graficRezervăriToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.graficRezervăriToolStripMenuItem.Text = "Grafic rezervări";
            this.graficRezervăriToolStripMenuItem.Click += new System.EventHandler(this.graficRezervăriToolStripMenuItem_Click);
            // 
            // graficOspătariToolStripMenuItem
            // 
            this.graficOspătariToolStripMenuItem.Name = "graficOspătariToolStripMenuItem";
            this.graficOspătariToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.graficOspătariToolStripMenuItem.Text = "Grafic ospătari";
            this.graficOspătariToolStripMenuItem.Click += new System.EventHandler(this.graficOspătariToolStripMenuItem_Click);
            // 
            // graficMeseToolStripMenuItem
            // 
            this.graficMeseToolStripMenuItem.Name = "graficMeseToolStripMenuItem";
            this.graficMeseToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.graficMeseToolStripMenuItem.Text = "Grafic mese";
            this.graficMeseToolStripMenuItem.Click += new System.EventHandler(this.graficMeseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(129)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumarPersoaneRezervare)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdaugareRezervare;
        private System.Windows.Forms.TextBox textBoxIdRezervare;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumarPersoaneRezervare;
        private System.Windows.Forms.ComboBox comboBoxMasaDisponibilaPtRezervare;
        private System.Windows.Forms.ComboBox comboBoxOspatarDisponibilPtRezervare;
        private System.Windows.Forms.ListBox IstoricRezervari;
        private System.Windows.Forms.Button buttonVizualizareIstoricRezervari;
        private System.Windows.Forms.Button buttonAccesOspatari;
        private System.Windows.Forms.Button buttonAccesMese;
        private System.Windows.Forms.Button buttonAccesMeniuri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHelpInstructiuni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareGraficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficRezervăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficOspătariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficMeseToolStripMenuItem;
        private System.Windows.Forms.Label lblRezervareSelectata;
        private System.Windows.Forms.Button button1;
    }
}

