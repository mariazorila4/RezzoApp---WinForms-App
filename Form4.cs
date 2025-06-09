using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Activitatea_unui_restaurant
{
    public partial class Form4: Form
    {
        //trimitere lista din form1
        //( acolo a fost declarata ca un fel de variabila globala pentru a putea fi folosita si in form4)
        private List<Meniu> meniuri;
        public Form4(List<Meniu> listaPrimita)
        {
            InitializeComponent();
            meniuri = listaPrimita;

            IncarcareDateInitiale();

            //configurare valori tip
            comboBoxTipMeniu.DataSource = Enum.GetValues(typeof(Tip));
            comboBoxTipMeniu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipMeniu.SelectedIndex = -1;
        }

        //ADAUGARE
        private void buttonAdaugareMeniu_Click(object sender, EventArgs e)
        {
            string numeMeniu = textBoxNumeMeniu.Text;
            float pret;

            //ERORI
            //eroare pentru numele meniului
            errorProvider1.Clear();

            if (textBoxNumeMeniu.Text == "")
            {
                errorProvider1.SetError(textBoxNumeMeniu, "Numele meniului este obligatoriu!!");
                return;
            }
            else if (!char.IsUpper(textBoxNumeMeniu.Text[0]))
            {
                errorProvider1.SetError(textBoxNumeMeniu, "Numele meniului poate incepe doar cu litera mare!");
                textBoxNumeMeniu.ForeColor = Color.Red;
                textBoxNumeMeniu.Focus();
            }
            else
                textBoxNumeMeniu.ForeColor = SystemColors.WindowText;

            //eroare pentru tipul meniului
            if (comboBoxTipMeniu.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxTipMeniu, "Selecteaza tipul corespunzator pentru meniu!");
                return;
            }

            Tip tipulSelectat = (Tip)comboBoxTipMeniu.SelectedItem;

            //eroare pentru pretul meniului
            errorProvider1.Clear();
            if (textBoxPretMeniu.Text == "")
            {
                errorProvider1.SetError(textBoxPretMeniu, "Pretul meniului este obligatoriu!!");
                return;
            }


            try
            {
                pret = float.Parse(textBoxPretMeniu.Text);

                if (pret < 1 || pret > 300)
                {
                    errorProvider1.SetError(textBoxPretMeniu, "Pretul meniului trebuie să fie între 1 și 300 lei!!");
                    textBoxPretMeniu.ForeColor = Color.Red;
                    textBoxPretMeniu.Focus();
                    return;
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxPretMeniu, "Doar valori numerice!!");
                textBoxPretMeniu.ForeColor = Color.Red;
                textBoxPretMeniu.Focus();
                return;
            }

            textBoxPretMeniu.ForeColor = SystemColors.WindowText;

            //ADAUGARE IN LISTA
            Meniu meniu = new Meniu(numeMeniu, tipulSelectat, pret);
            meniuri.Add(meniu);

            //cleanup
            textBoxNumeMeniu.Text = "";
            comboBoxTipMeniu.SelectedIndex = -1;
            textBoxPretMeniu.Text = "";
            buttonAdaugareMeniu.Text = "&Adaugă meniu(" + meniuri.Count + ")";
        }

        //VIZUALIZARE LISTA
        private void buttonVizualizareListaMeniuri_Click(object sender, EventArgs e)
        {
            ListaMeniuri.Items.Clear();

            foreach (Meniu meniu in meniuri)
                ListaMeniuri.Items.Add(meniu);
        }

        private void IncarcareDateInitiale()
        {
            if (File.Exists("date_restaurant\\meniuri.json"))
            {
                var options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                string json = File.ReadAllText("date_restaurant\\meniuri.json");
                var listaDeserializata = JsonSerializer.Deserialize<List<Meniu>>(json, options);

                meniuri.Clear();
                foreach (var m in listaDeserializata)
                    meniuri.Add(m);

                buttonAdaugareMeniu.Text = "&Adaugă meniu(" + meniuri.Count + ")";
            }
        }

        //SERIALIZE
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, Converters= { new JsonStringEnumConverter() } };
            string jsonstring = JsonSerializer.Serialize(meniuri, options);

            Directory.CreateDirectory("date_restaurant");
            File.WriteAllText("date_restaurant\\meniuri.json", jsonstring);//se salveaza in folderul date_restaurant din debug-ul proiectului
            MessageBox.Show("Fisierul a fost creat cu succes.", "meniuri.json");
        }

        //DESERIALIZE
        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("date_restaurant\\meniuri.json"))
            {
                var options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };

                string json = File.ReadAllText("date_restaurant\\meniuri.json");
                meniuri = JsonSerializer.Deserialize<List<Meniu>>(json, options);

                buttonAdaugareMeniu.Text = "&Adaugă meniu(" + meniuri.Count + ")";
                
                //Actualizare listbox dupa deserializare
                ListaMeniuri.Items.Clear();
                foreach (Meniu m in meniuri)
                    ListaMeniuri.Items.Add(m);

                MessageBox.Show("Fisierul a fost deserializat cu succes.", "meniuri.json");
            }
            else
            {
                MessageBox.Show("Fisierul meniuri.json nu există!");
            }
        }
    }

    //CLASE SI CONSTRUCTORI
    public class Meniu
    {
        public string numeMeniu { get; set; }
        public Tip tip { get; set; }
        public float pret { get; set; }

        public Meniu()
        {
            numeMeniu = "";
            pret = 0;
        }

        public Meniu(string numeMeniu, Tip tip, float pret)
        {
            this.numeMeniu = numeMeniu;
            this.tip = tip;
            this.pret = pret;
        }

        public override string ToString()
        {
            return "Meniu - Nume: "+numeMeniu+", Tip: "+tip+", Pret: "+pret+"lei";
        }
    }

    public enum Tip { Bautura, Mancare, Desert}
}
