using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Activitatea_unui_restaurant
{
    public partial class Form3: Form
    {
        //trimitere lista din form1
        //( acolo a fost declarata ca un fel de variabila globala pentru a putea fi folosita si in form3)
        private List<Masa> mese;
        public Form3(List<Masa> listaPrimita)
        {
            InitializeComponent();
            mese = listaPrimita;

            IncarcareDateInitiale();
        }

        //ADAUGARE 
        private void buttonAdaugareMasa_Click(object sender, EventArgs e)
        {
            int numarMasa = (int)numericUpDownNumarMasa.Value;
            int numarLocuriMasa = (int)numericUpDownNumarLocuriMasa.Value;
            bool disponibilitate = checkBoxDisponibilitate.Checked;

            //ERORI
            //eroare pentru numarul mesei - restaurantul are 20 de mese
            errorProvider1.Clear();
            if(numarMasa<1||numarMasa>100)
            {
                errorProvider1.SetError(numericUpDownNumarMasa, "Alegeti un numar intre 1 si 100!");
                return;
            }

            //eroare pentru numarul de locuri - avem mese cu maxim 8 locuri
            errorProvider1.Clear();
            if(numarLocuriMasa<2||numarLocuriMasa>8)
            {
                errorProvider1.SetError(numericUpDownNumarLocuriMasa, "Puteti alege intre 2 pana la 8 locuri pentru o masa");
                return;
            }

            //eroare duplicat masa
            foreach (Masa m in mese)
            {
                if (m.numarMasa == numarMasa)
                {
                    errorProvider1.SetError(numericUpDownNumarMasa, "Aceasta masa exista deja!");
                    return;
                }
            }


            //ADAUGA IN LISTA
            Masa masa = new Masa(numarMasa, numarLocuriMasa, disponibilitate);
            mese.Add(masa);

            //cleanup
            numericUpDownNumarMasa.Value = 1;
            numericUpDownNumarLocuriMasa.Value = 2;
            checkBoxDisponibilitate.Checked = false;
            buttonAdaugareMasa.Text = "&Adaugă masa(" + mese.Count + ")";
            
        }

        //VIZUALIZARE LISTA
        private void buttonVizualizareListaMese_Click(object sender, EventArgs e)
        {
            ListaMese.Items.Clear();

            foreach (Masa masa in mese)
                ListaMese.Items.Add(masa);
        }

        private void IncarcareDateInitiale()
        {
            if (File.Exists("date_restaurant\\mese.json"))
            {
                string json = File.ReadAllText("date_restaurant\\mese.json");
                var listaDeserializata = JsonSerializer.Deserialize<List<Masa>>(json);

                mese.Clear();
                foreach (var m in listaDeserializata)
                    mese.Add(m);

                buttonAdaugareMasa.Text = "&Adaugă masa(" + mese.Count + ")";
            }
        }

        //SERIALIZE
        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonstring = JsonSerializer.Serialize(mese, options);

            Directory.CreateDirectory("date_restaurant");
            File.WriteAllText("date_restaurant\\mese.json", jsonstring);//se salveaza in folderul date_restaurant din debug-ul proiectului
            MessageBox.Show("Fisierul a fost creat cu succes.", "mese.json");
        }

        //DESERIALIZE
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("date_restaurant\\mese.json"))
            {
                string json = File.ReadAllText("date_restaurant\\mese.json");
                mese = JsonSerializer.Deserialize<List<Masa>>(json);
                buttonAdaugareMasa.Text = "&Adaugă masă(" + mese.Count + ")";

                //Actualizare listbox dupa deserializare
                ListaMese.Items.Clear();
                foreach (Masa masa in mese)
                    ListaMese.Items.Add(masa);

                MessageBox.Show("Fisierul a fost deserializat cu succes.", "mese.json");
            }
            else
            {
                MessageBox.Show("Fisierul mese.json nu exista!");
            }
        }
    }

    public class Masa
    {
        public int numarMasa { get; set; }
        public int numarLocuriMasa { get; set; }
        public bool disponibilitate { get; set; }

        public Masa()
        {
            numarMasa=0;
            numarLocuriMasa = 0;
            disponibilitate = true;
        }

        public Masa(int numarMasa, int numarLocuriMasa, bool disponibilitate)
        {
            this.numarMasa = numarMasa;
            this.numarLocuriMasa = numarLocuriMasa;
            this.disponibilitate = disponibilitate;
        }

        public override string ToString()
        {
            return "Masa - Numar masa: "+numarMasa+", Numar locuri: "+numarLocuriMasa+", Disponibilitate: "+(disponibilitate?"disponibila":"ocupata");
        }
    }
}
