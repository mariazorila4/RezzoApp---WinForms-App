using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Activitatea_unui_restaurant
{
   
    public partial class Form2 : Form
    {
        //trimitere lista din form1
        //( acolo a fost declarata ca un fel de variabila globala pentru a putea fi folosita si in form2)
        private List<Ospatar> ospatari;

        //variabile globale pentru partea de drag & drop realizata pentru selectarea ospatarilor din listbox
        int y = 10;
        int nrOspatariSelectati = 0;
        const int MAX_DROP = 3;
        List<Ospatar> ospatariPromovati = new List<Ospatar>();

        public Form2(List<Ospatar> listaPrimita)
        {
            InitializeComponent();
            ospatari = listaPrimita;

            IncarcareDateInitiale();

            //configurare valori tura
            comboBoxTura.DataSource = Enum.GetValues(typeof(Tura));
            comboBoxTura.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTura.SelectedIndex = -1;

        }

        //ADAUGARE 
        private void buttonAdaugareOspatar_Click(object sender, EventArgs e)
        {
            int id;
            string nume = textBoxNumeOspatar.Text;
            string prenume = textBoxPrenumeOspatar.Text;
            
            //ERORI
            //eroare pentru id
            errorProvider1.Clear();
            if (textBoxIdOspatar.Text == "")
            {
                errorProvider1.SetError(textBoxIdOspatar, "ID-ul ospatarului este obligatoriu!!");
                return;
            }
            
            
            try
            {
              id = int.Parse(textBoxIdOspatar.Text);

              if (id < 101 || id > 150)
              {
                errorProvider1.SetError(textBoxIdOspatar, "ID-ul ospatarului trebuie sa fie între 101 și 150!!");
                textBoxIdOspatar.ForeColor = Color.Red;
                textBoxIdOspatar.Focus();
                return;
              }
            }
            catch
            {
              errorProvider1.SetError(textBoxIdOspatar, "Doar valori numerice!!");
              textBoxIdOspatar.ForeColor = Color.Red;
              textBoxIdOspatar.Focus();
              return;
            }
            
            textBoxIdOspatar.ForeColor = SystemColors.WindowText;
            errorProvider1.Clear();

            foreach (Ospatar o in ospatari)
            {
                if (o.id == id)
                {
                    errorProvider1.SetError(textBoxIdOspatar, "ID-ul ospatarului exista deja!");
                    return;
                }
            }

            //eroare pentru nume si prenume
            errorProvider1.Clear();

            if (textBoxNumeOspatar.Text == "")
            {
                errorProvider1.SetError(textBoxNumeOspatar, "Numele ospatarului este obligatoriu!!");
                return;
            }
            else if (!char.IsUpper(textBoxNumeOspatar.Text[0]))
            {
                errorProvider1.SetError(textBoxNumeOspatar, "Numele ospatarului poate incepe doar cu litera mare!");
                textBoxNumeOspatar.ForeColor = Color.Red;
                textBoxNumeOspatar.Focus();
            }
            else
                textBoxNumeOspatar.ForeColor = SystemColors.WindowText;

            if (textBoxPrenumeOspatar.Text == "")
            {
                errorProvider1.SetError(textBoxPrenumeOspatar, "Prenumele ospatarului este obligatoriu!!");
                return;
            }
            else if (!char.IsUpper(textBoxPrenumeOspatar.Text[0]))
            {
                errorProvider1.SetError(textBoxPrenumeOspatar, "Prenumele ospatarului poate incepe doar cu litera mare!");
                textBoxPrenumeOspatar.ForeColor = Color.Red;
                textBoxPrenumeOspatar.Focus();
            }
            else
                textBoxPrenumeOspatar.ForeColor = SystemColors.WindowText;

            //eroare pentru tura
            if (comboBoxTura.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxTura, "Selecteaza tura corespunzatoare pentru ospatar!");
                return;
            }

            Tura turaSelectata=(Tura)comboBoxTura.SelectedItem;

            //ADAUGARE IN LISTA
            Ospatar ospatar = new Ospatar(id, nume, prenume, turaSelectata);
            ospatari.Add(ospatar);

            //CLEANUP
            textBoxIdOspatar.Text = "";
            textBoxNumeOspatar.Text = "";
            textBoxPrenumeOspatar.Text = "";
            comboBoxTura.SelectedIndex = -1;
            buttonAdaugareOspatar.Text = "&Adaugă ospătar(" + ospatari.Count + ")";
        }


        //VIZUALIZARE LISTA
        private void buttonVizualizareListaOspatari_Click(object sender, EventArgs e)
        {
            ListaOspatari.Items.Clear();

            foreach (Ospatar ospatar in ospatari)
                ListaOspatari.Items.Add(ospatar);
        }

        //metoda pentru incarcarea automata a listei la apelare ctrl+f5
        private void IncarcareDateInitiale()
        {
            if (File.Exists("date_restaurant\\ospatari.json"))
            {
                var options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                string json = File.ReadAllText("date_restaurant\\ospatari.json");
                var listaDeserializata = JsonSerializer.Deserialize<List<Ospatar>>(json, options);

                ospatari.Clear();
                foreach (var o in listaDeserializata)
                    ospatari.Add(o);

                buttonAdaugareOspatar.Text = "&Adaugă ospătar(" + ospatari.Count + ")";
            }
        }

        //SERIALIZE
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonStringEnumConverter() } };
            string jsonstring = JsonSerializer.Serialize(ospatari, options);

            Directory.CreateDirectory("date_restaurant");
            File.WriteAllText("date_restaurant\\ospatari.json", jsonstring);//se salveaza in folderul date_restaurant din debug-ul proiectului
            MessageBox.Show("Fisierul a fost creat cu succes.", "ospatari.json");
        }

        //DESERIALIZE
        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("date_restaurant\\ospatari.json"))
            {
                var options = new JsonSerializerOptions{ Converters = { new JsonStringEnumConverter() } };

                string json = File.ReadAllText("date_restaurant\\ospatari.json");
                ospatari = JsonSerializer.Deserialize<List<Ospatar>>(json, options);

                buttonAdaugareOspatar.Text = "&Adaugă ospătar(" + ospatari.Count + ")";
                
                ListaOspatari.Items.Clear();
                foreach (Ospatar ospatar in ospatari)
                    ListaOspatari.Items.Add(ospatar);

                MessageBox.Show("Fisierul a fost deserializat cu succes.", "ospatari.json");

            }
            else
            {
                MessageBox.Show("Fisierul ospatari.json nu exista!");
            }
        }

        //drag & drop

        //selectare din lista ospatari, pt ca avem o lista vom folosi SelectedItem pt a selecta ospatarii
        private void ListaOspatari_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaOspatari.SelectedItem == null)
                return;

            DragDropEffects rezultat = DragDropEffects.None;

            object elementSelectat = ListaOspatari.SelectedItem;

            if (e.Button == MouseButtons.Left)
                rezultat = ListaOspatari.DoDragDrop(elementSelectat, DragDropEffects.Copy);

            if (e.Button == MouseButtons.Right)
                rezultat = ListaOspatari.DoDragDrop(elementSelectat, DragDropEffects.Move);

            if (rezultat == DragDropEffects.Move)
                ListaOspatari.Items.Remove(elementSelectat);
        }

        private void panelTopDragLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Nu ai tras ospatarul in interiorul chenarului!");
        }

        private void panelTopDragEnter(object sender, DragEventArgs e)
        {
            if (nrOspatariSelectati >= MAX_DROP)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            if (e.Data.GetDataPresent(typeof(Ospatar)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelTopDragDrop(object sender, DragEventArgs e)
        {
            if (nrOspatariSelectati >= MAX_DROP)
            {
                MessageBox.Show("Ai atins limita de 3 ospatari!");
                return;
            }

            //facem aceasta partea pt a putea afisa in acelasi timp mai multi ospatari
            //dar si pt a ne orienta in functie de dimensiunile panel-ului si nr de ospatari selectati pt incadrarea ospatarilor in panel
            Ospatar osp = (Ospatar)e.Data.GetData(typeof(Ospatar));
            if (osp != null)
            {
                Graphics gr = panelTop.CreateGraphics();
                gr.DrawString(osp.ToString(), this.Font, new SolidBrush(Color.DarkGreen), 40, 40 + nrOspatariSelectati * 20);
                nrOspatariSelectati++;
                ospatariPromovati.Add(osp);
            }

            if (nrOspatariSelectati == MAX_DROP)
            {
                MessageBox.Show("Topul este full. Nu mai poti adauga ospatari pentru promovare");
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string indicatii = "1. Apasa pe Vizualizeaza lista cu ospatari pentru a putea vedea ospatarii disponibili" +
                "pe care ii poti selecta pentru a-i nominaliza pentru promovare.\n" +
                "\n" +
                "2.Apasa click stanga/dreapta pe ospatarul dorit, tine apasat pe mouse si trage in interiorul chenarului" +
                "Top 3 ospatari selectati pentru promovare pentru a adauga ospatarul in top.\n" +
                "\n\n" +
                "Atentie! Nu poti nominaliza mai mult de 3 ospatari pentru promovare.";

            MessageBox.Show(indicatii);
        }
    }


    //CLASE SI CONSTRUCTORI
    public enum Tura
    {
        Dimineata,  //10:00 - 14:00
        DupaAmiaza, //14:00 - 18:00
        Seara       //18:00 - 22:00
    }

    [Serializable]
    public class Ospatar
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public Tura tura { get; set; }

        public Ospatar()
        {
            id = 0;
            nume = "";
            prenume = "";
        }

        public Ospatar(int id, string nume, string prenume, Tura tura)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.tura = tura;
        }

        public override string ToString()
        {
            string interval = "";

            switch (tura)
            {
                case Tura.Dimineata:
                    interval = "10:00 - 14:00";
                    break;
                case Tura.DupaAmiaza:
                    interval = "14:00 - 18:00";
                    break;
                case Tura.Seara:
                    interval = "18:00 - 22:00";
                    break;
            }

            return "Ospatar - ID: " + id + ", Nume: " + nume + ", Prenume: " + prenume + ", Tura: " + tura+" ("+interval+")";
        }
    }

}
