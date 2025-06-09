namespace Activitatea_unui_restaurant
{
    partial class Form8
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Delete_ospatari = new System.Windows.Forms.Button();
            this.btn_Update_ospatari = new System.Windows.Forms.Button();
            this.btn_Insert_ospatari = new System.Windows.Forms.Button();
            this.btn_Select_ospatari = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_ospatar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Delete_mese = new System.Windows.Forms.Button();
            this.btn_Update_mese = new System.Windows.Forms.Button();
            this.btn_Insert_mese = new System.Windows.Forms.Button();
            this.btn_Select_mese = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Nr_Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_Locuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disponibilitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Delete_meniuri = new System.Windows.Forms.Button();
            this.btn_Update_meniuri = new System.Windows.Forms.Button();
            this.btn_Insert_meniuri = new System.Windows.Forms.Button();
            this.btn_Select_meniuri = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucAdaugareProdus1 = new Activitatea_unui_restaurant.UCAdaugareProdus();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.btn_Delete_ospatari);
            this.tabPage1.Controls.Add(this.btn_Update_ospatari);
            this.tabPage1.Controls.Add(this.btn_Insert_ospatari);
            this.tabPage1.Controls.Add(this.btn_Select_ospatari);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ospatari";
            // 
            // btn_Delete_ospatari
            // 
            this.btn_Delete_ospatari.Location = new System.Drawing.Point(650, 510);
            this.btn_Delete_ospatari.Name = "btn_Delete_ospatari";
            this.btn_Delete_ospatari.Size = new System.Drawing.Size(128, 47);
            this.btn_Delete_ospatari.TabIndex = 9;
            this.btn_Delete_ospatari.Text = "&DELETE";
            this.btn_Delete_ospatari.UseVisualStyleBackColor = true;
            this.btn_Delete_ospatari.Click += new System.EventHandler(this.btn_Delete_ospatari_Click);
            // 
            // btn_Update_ospatari
            // 
            this.btn_Update_ospatari.Location = new System.Drawing.Point(447, 510);
            this.btn_Update_ospatari.Name = "btn_Update_ospatari";
            this.btn_Update_ospatari.Size = new System.Drawing.Size(137, 51);
            this.btn_Update_ospatari.TabIndex = 8;
            this.btn_Update_ospatari.Text = "&UPDATE";
            this.btn_Update_ospatari.UseVisualStyleBackColor = true;
            this.btn_Update_ospatari.Click += new System.EventHandler(this.btn_Update_ospatari_Click);
            // 
            // btn_Insert_ospatari
            // 
            this.btn_Insert_ospatari.Location = new System.Drawing.Point(224, 510);
            this.btn_Insert_ospatari.Name = "btn_Insert_ospatari";
            this.btn_Insert_ospatari.Size = new System.Drawing.Size(144, 54);
            this.btn_Insert_ospatari.TabIndex = 7;
            this.btn_Insert_ospatari.Text = "&INSERT";
            this.btn_Insert_ospatari.UseVisualStyleBackColor = true;
            this.btn_Insert_ospatari.Click += new System.EventHandler(this.btn_Insert_ospatari_Click);
            // 
            // btn_Select_ospatari
            // 
            this.btn_Select_ospatari.Location = new System.Drawing.Point(19, 510);
            this.btn_Select_ospatari.Name = "btn_Select_ospatari";
            this.btn_Select_ospatari.Size = new System.Drawing.Size(131, 54);
            this.btn_Select_ospatari.TabIndex = 6;
            this.btn_Select_ospatari.Text = "&SELECT";
            this.btn_Select_ospatari.UseVisualStyleBackColor = true;
            this.btn_Select_ospatari.Click += new System.EventHandler(this.btn_Select_ospatari_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_ospatar,
            this.Nume,
            this.Prenume,
            this.Tura});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 477);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_ospatar
            // 
            this.ID_ospatar.Text = "ID ospatar";
            this.ID_ospatar.Width = 100;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 200;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 200;
            // 
            // Tura
            // 
            this.Tura.Text = "Tura";
            this.Tura.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Controls.Add(this.btn_Delete_mese);
            this.tabPage2.Controls.Add(this.btn_Update_mese);
            this.tabPage2.Controls.Add(this.btn_Insert_mese);
            this.tabPage2.Controls.Add(this.btn_Select_mese);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mese";
            // 
            // btn_Delete_mese
            // 
            this.btn_Delete_mese.Location = new System.Drawing.Point(702, 512);
            this.btn_Delete_mese.Name = "btn_Delete_mese";
            this.btn_Delete_mese.Size = new System.Drawing.Size(128, 47);
            this.btn_Delete_mese.TabIndex = 14;
            this.btn_Delete_mese.Text = "&DELETE";
            this.btn_Delete_mese.UseVisualStyleBackColor = true;
            this.btn_Delete_mese.Click += new System.EventHandler(this.btn_Delete_mese_Click);
            // 
            // btn_Update_mese
            // 
            this.btn_Update_mese.Location = new System.Drawing.Point(490, 513);
            this.btn_Update_mese.Name = "btn_Update_mese";
            this.btn_Update_mese.Size = new System.Drawing.Size(137, 51);
            this.btn_Update_mese.TabIndex = 13;
            this.btn_Update_mese.Text = "&UPDATE";
            this.btn_Update_mese.UseVisualStyleBackColor = true;
            this.btn_Update_mese.Click += new System.EventHandler(this.btn_Update_mese_Click);
            // 
            // btn_Insert_mese
            // 
            this.btn_Insert_mese.Location = new System.Drawing.Point(241, 510);
            this.btn_Insert_mese.Name = "btn_Insert_mese";
            this.btn_Insert_mese.Size = new System.Drawing.Size(144, 54);
            this.btn_Insert_mese.TabIndex = 12;
            this.btn_Insert_mese.Text = "&INSERT";
            this.btn_Insert_mese.UseVisualStyleBackColor = true;
            this.btn_Insert_mese.Click += new System.EventHandler(this.btn_Insert_mese_Click);
            // 
            // btn_Select_mese
            // 
            this.btn_Select_mese.Location = new System.Drawing.Point(53, 510);
            this.btn_Select_mese.Name = "btn_Select_mese";
            this.btn_Select_mese.Size = new System.Drawing.Size(131, 54);
            this.btn_Select_mese.TabIndex = 11;
            this.btn_Select_mese.Text = "&SELECT";
            this.btn_Select_mese.UseVisualStyleBackColor = true;
            this.btn_Select_mese.Click += new System.EventHandler(this.btn_Select_mese_Click);
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr_Masa,
            this.Nr_Locuri,
            this.Disponibilitate});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(232, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(408, 477);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Nr_Masa
            // 
            this.Nr_Masa.Text = "Numar masa";
            this.Nr_Masa.Width = 100;
            // 
            // Nr_Locuri
            // 
            this.Nr_Locuri.Text = "Numar locuri";
            this.Nr_Locuri.Width = 100;
            // 
            // Disponibilitate
            // 
            this.Disponibilitate.Text = "Disponibilitate";
            this.Disponibilitate.Width = 200;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.Controls.Add(this.ucAdaugareProdus1);
            this.tabPage3.Controls.Add(this.btn_Delete_meniuri);
            this.tabPage3.Controls.Add(this.btn_Update_meniuri);
            this.tabPage3.Controls.Add(this.btn_Insert_meniuri);
            this.tabPage3.Controls.Add(this.btn_Select_meniuri);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1015, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meniuri";
            // 
            // btn_Delete_meniuri
            // 
            this.btn_Delete_meniuri.Location = new System.Drawing.Point(734, 499);
            this.btn_Delete_meniuri.Name = "btn_Delete_meniuri";
            this.btn_Delete_meniuri.Size = new System.Drawing.Size(128, 47);
            this.btn_Delete_meniuri.TabIndex = 14;
            this.btn_Delete_meniuri.Text = "&DELETE";
            this.btn_Delete_meniuri.UseVisualStyleBackColor = true;
            this.btn_Delete_meniuri.Click += new System.EventHandler(this.btn_Delete_meniuri_Click);
            // 
            // btn_Update_meniuri
            // 
            this.btn_Update_meniuri.Location = new System.Drawing.Point(540, 497);
            this.btn_Update_meniuri.Name = "btn_Update_meniuri";
            this.btn_Update_meniuri.Size = new System.Drawing.Size(137, 51);
            this.btn_Update_meniuri.TabIndex = 13;
            this.btn_Update_meniuri.Text = "&UPDATE";
            this.btn_Update_meniuri.UseVisualStyleBackColor = true;
            this.btn_Update_meniuri.Click += new System.EventHandler(this.btn_Update_meniuri_Click);
            // 
            // btn_Insert_meniuri
            // 
            this.btn_Insert_meniuri.Location = new System.Drawing.Point(90, 499);
            this.btn_Insert_meniuri.Name = "btn_Insert_meniuri";
            this.btn_Insert_meniuri.Size = new System.Drawing.Size(144, 54);
            this.btn_Insert_meniuri.TabIndex = 12;
            this.btn_Insert_meniuri.Text = "&INSERT";
            this.btn_Insert_meniuri.UseVisualStyleBackColor = true;
            this.btn_Insert_meniuri.Click += new System.EventHandler(this.btn_Insert_meniuri_Click);
            // 
            // btn_Select_meniuri
            // 
            this.btn_Select_meniuri.Location = new System.Drawing.Point(350, 495);
            this.btn_Select_meniuri.Name = "btn_Select_meniuri";
            this.btn_Select_meniuri.Size = new System.Drawing.Size(131, 54);
            this.btn_Select_meniuri.TabIndex = 11;
            this.btn_Select_meniuri.Text = "&SELECT";
            this.btn_Select_meniuri.UseVisualStyleBackColor = true;
            this.btn_Select_meniuri.Click += new System.EventHandler(this.btn_Select_meniuri_Click);
            // 
            // listView3
            // 
            this.listView3.CheckBoxes = true;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Tip,
            this.Pret});
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(350, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(512, 477);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 200;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 120;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            // 
            // ucAdaugareProdus1
            // 
            this.ucAdaugareProdus1.BackColor = System.Drawing.Color.LightCoral;
            this.ucAdaugareProdus1.Location = new System.Drawing.Point(22, 26);
            this.ucAdaugareProdus1.Name = "ucAdaugareProdus1";
            this.ucAdaugareProdus1.Size = new System.Drawing.Size(284, 348);
            this.ucAdaugareProdus1.TabIndex = 15;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form8";
            this.Text = "Modificari date rezervari";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Delete_ospatari;
        private System.Windows.Forms.Button btn_Update_ospatari;
        private System.Windows.Forms.Button btn_Insert_ospatari;
        private System.Windows.Forms.Button btn_Select_ospatari;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Delete_mese;
        private System.Windows.Forms.Button btn_Update_mese;
        private System.Windows.Forms.Button btn_Insert_mese;
        private System.Windows.Forms.Button btn_Select_mese;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Delete_meniuri;
        private System.Windows.Forms.Button btn_Update_meniuri;
        private System.Windows.Forms.Button btn_Insert_meniuri;
        private System.Windows.Forms.Button btn_Select_meniuri;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader ID_ospatar;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Tura;
        private System.Windows.Forms.ColumnHeader Nr_Masa;
        private System.Windows.Forms.ColumnHeader Nr_Locuri;
        private System.Windows.Forms.ColumnHeader Disponibilitate;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Pret;
        private UCAdaugareProdus ucAdaugareProdus1;
    }
}