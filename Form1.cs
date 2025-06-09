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
    public partial class Form1: Form
    {
        //am pus listele pt toate obiectele pentru a putea face legatura dintre form1 si celelalte
        List<Rezervare> rezervari = new List<Rezervare>();
        List<Ospatar> listaOspatari = new List<Ospatar>();
        List<Masa> listaMese = new List<Masa>();
        List<Meniu> listaMeniuri = new List<Meniu>();

        public Form1()
        {
            InitializeComponent();

            //pentru a incarca automat datele la deschiderea form1
            IncarcaDateInitiale();

            //actualizare pt data si ora aleasa
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            //obiectele ospatar si masa devin membrii ai obiectului rezervare
            listaMese = new List<Masa>();
            listaOspatari = new List<Ospatar>();

            //pentru a vedea datele din form2 si form3 dupa ce le-am adaugat in timp real 
            this.Activated += Form1_Activated;

            //convertire data pentru a accepta si ora
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }

        //ADAUGARE
        private void buttonAdaugareRezervare_Click(object sender, EventArgs e)
        {
            int idRezervare;
            string numeClient = textBoxNumeClient.Text;
            DateTime data_si_ora = dateTimePicker1.Value;
            int nrPersoane = (int)numericUpDownNumarPersoaneRezervare.Value;
           
            //ERORI
            //eroare pentru id rezervare
            errorProvider1.Clear();
            if (textBoxIdRezervare.Text == "")
            {
                errorProvider1.SetError(textBoxIdRezervare, "ID-ul rezervarii este obligatoriu!!");
                return;
            }


            try
            {
                idRezervare = int.Parse(textBoxIdRezervare.Text);

                if (idRezervare < 2201 || idRezervare > 2340)
                {
                    errorProvider1.SetError(textBoxIdRezervare, "ID-ul rezervarii trebuie sa fie între 2201 și 2340!!");
                    textBoxIdRezervare.ForeColor = Color.Red;
                    textBoxIdRezervare.Focus();
                    return;
                }
            }
            catch
            {
                errorProvider1.SetError(textBoxIdRezervare, "Doar valori numerice!!");
                textBoxIdRezervare.ForeColor = Color.Red;
                textBoxIdRezervare.Focus();
                return;
            }

            textBoxIdRezervare.ForeColor = SystemColors.WindowText;
            errorProvider1.Clear();

            foreach (Rezervare r in rezervari)
            {
                if (r.idRezervare == idRezervare)
                {
                    errorProvider1.SetError(textBoxIdRezervare, "ID-ul rezervarii exista deja!");
                    return;
                }
            }

            //eroare pentru nume client
            errorProvider1.Clear();

            if (textBoxNumeClient.Text == "")
            {
                errorProvider1.SetError(textBoxNumeClient, "Numele clientului este obligatoriu!!");
                return;
            }
            else if (!char.IsUpper(textBoxNumeClient.Text[0]))
            {
                errorProvider1.SetError(textBoxNumeClient, "Numele clientului poate incepe doar cu litera mare!");
                textBoxNumeClient.ForeColor = Color.Red;
                textBoxNumeClient.Focus();
            }
            else
                textBoxNumeClient.ForeColor = SystemColors.WindowText;

            //eroare pentru data si ora
            if (data_si_ora <= DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker1, "Selecteaza o data din viitor!");
                return;
            }

            //eroare pentru numarul de persoane
            errorProvider1.Clear();
            if (nrPersoane < 1 || nrPersoane > 8)
            {
                errorProvider1.SetError(numericUpDownNumarPersoaneRezervare, "Puteti alege intre 1 pana la 8 persoane pentru o rezervare");
                return;
            }

            //eroare pentru masa disponibila
            if (comboBoxMasaDisponibilaPtRezervare.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxMasaDisponibilaPtRezervare, "Selecteaza masa disponibila pentru rezervare!");
                return;
            }

            Masa masaDisponibila = (Masa)comboBoxMasaDisponibilaPtRezervare.SelectedItem;

            //eroare pentru ospatar disponibil
            if (comboBoxOspatarDisponibilPtRezervare.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxOspatarDisponibilPtRezervare, "Selecteaza ospatarul disponibil pentru rezervare!");
                return;
            }

            Ospatar ospatarDisponibil = (Ospatar)comboBoxOspatarDisponibilPtRezervare.SelectedItem;

            //ADAUGARE IN LISTA
            Rezervare rezervare = new Rezervare(idRezervare, numeClient, data_si_ora, nrPersoane, masaDisponibila, ospatarDisponibil);
            rezervari.Add(rezervare);

            //actualizam comboxurile din rezervare pt masa si ospatar
            ActualizeazaComboBoxuri();

            //cleanup
            textBoxIdRezervare.Text = "";
            textBoxNumeClient.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            numericUpDownNumarPersoaneRezervare.Value = 0;
            comboBoxMasaDisponibilaPtRezervare.SelectedIndex = -1;
            comboBoxOspatarDisponibilPtRezervare.SelectedIndex = -1;
            buttonAdaugareRezervare.Text = "&Adaugă rezervare(" + rezervari.Count + ")";
        }

        //conexiuni form1 cu form2, form3 si form4
        private void buttonAccesOspatari_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(listaOspatari);
            frm2.Show();
        }

        private void buttonAccesMese_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(listaMese);
            frm3.Show();
        }

        private void buttonAccesMeniuri_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(listaMeniuri);
            frm4.Show();
        }

        //VIZUALIZARE LISTA
        private void buttonVizualizareIstoricRezervari_Click(object sender, EventArgs e)
        {
            IstoricRezervari.Items.Clear();

            foreach (Rezervare rezervare in rezervari)
                IstoricRezervari.Items.Add(rezervare);
        }

        //apel pt a putea vedea in timp real ce am adaugat in listele ospatar si masa
        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBoxMasaDisponibilaPtRezervare.DataSource = null;
            comboBoxMasaDisponibilaPtRezervare.DataSource = listaMese;
            comboBoxMasaDisponibilaPtRezervare.DisplayMember = "ToString";

            comboBoxOspatarDisponibilPtRezervare.DataSource = null;
            comboBoxOspatarDisponibilPtRezervare.DataSource = listaOspatari;
            comboBoxOspatarDisponibilPtRezervare.DisplayMember = "ToString";
        }

        //metoda pentru actualizare comboxuri masa si ospatar din rezervare
        public void ActualizeazaComboBoxuri()
        {
            DateTime dataSelectata = dateTimePicker1.Value;
            List<Masa> meseDisponibile = new List<Masa>();

            foreach (Masa m in listaMese)
            {
                //cautam daca masa e deja rezervata intr-un interval de 2h fața de dataSelectata
                bool esteOcupata = rezervari.Any(r =>
                    r.masa.numarMasa == m.numarMasa &&
                    Math.Abs((r.data_si_ora - dataSelectata).TotalMinutes) < 120);

                if (!esteOcupata)
                    meseDisponibile.Add(m);
            }

            comboBoxMasaDisponibilaPtRezervare.DataSource = null;
            comboBoxMasaDisponibilaPtRezervare.DataSource = meseDisponibile;
            comboBoxMasaDisponibilaPtRezervare.DisplayMember = "ToString";

            comboBoxOspatarDisponibilPtRezervare.DataSource = null;
            comboBoxOspatarDisponibilPtRezervare.DataSource = listaOspatari;
            comboBoxOspatarDisponibilPtRezervare.DisplayMember = "ToString";
            comboBoxOspatarDisponibilPtRezervare.SelectedIndex = -1;
        }


        //metoda pentru incarcarea automata a listei la apelare ctrl+f5
        private void IncarcaDateInitiale()
        {
            // deserialize mese
            if (File.Exists("date_restaurant\\mese.json"))
            {
                string json = File.ReadAllText("date_restaurant\\mese.json");
                listaMese = JsonSerializer.Deserialize<List<Masa>>(json);
            }

            // deserialize ospatari
            if (File.Exists("date_restaurant\\ospatari.json"))
            {
                var options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                string json = File.ReadAllText("date_restaurant\\ospatari.json");
                listaOspatari = JsonSerializer.Deserialize<List<Ospatar>>(json, options);
            }

            // deserialize rezervari + reasociere obiecte
            if (File.Exists("date_restaurant\\rezervari.json"))
            {
                string json = File.ReadAllText("date_restaurant\\rezervari.json");
                rezervari = JsonSerializer.Deserialize<List<Rezervare>>(json);

                foreach (Rezervare r in rezervari)
                {
                    foreach (Masa m in listaMese)
                    {
                        if (m.numarMasa == r.masa.numarMasa)
                        {
                            r.masa = m;
                            m.disponibilitate = false; // marcheaza ca ocupata
                            break;
                        }
                    }

                    foreach (Ospatar o in listaOspatari)
                    {
                        if (o.id == r.ospatar.id)
                        {
                            r.ospatar = o;
                            break;
                        }
                    }
                }
            }

            //actualizare comboxuri masa si ospatar
            ActualizeazaComboBoxuri();

            //actualizare listbox rezervari
            IstoricRezervari.Items.Clear();
            foreach (Rezervare r in rezervari)
                IstoricRezervari.Items.Add(r);
            buttonAdaugareRezervare.Text = "&Adaugă rezervare(" + rezervari.Count + ")";
        }

        //actualizeaza mesele in functie de ora si data selectate
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ActualizeazaComboBoxuri();
        }

        //SERIALIZE
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true};
            string jsonstring = JsonSerializer.Serialize(rezervari, options);

            Directory.CreateDirectory("date_restaurant");
            File.WriteAllText("date_restaurant\\rezervari.json", jsonstring);//se salveaza in folderul date_restaurant din debug-ul proiectului
            MessageBox.Show("Fisierul a fost creat cu succes.", "rezervari.json");
        }

        //DESERIALIZE
        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("date_restaurant\\rezervari.json"))
            {
                string json = File.ReadAllText("date_restaurant\\rezervari.json");
                rezervari = JsonSerializer.Deserialize<List<Rezervare>>(json);

                //reasociere mese si ospatari
                foreach (Rezervare r in rezervari)
                {
                    foreach (Masa m in listaMese)
                    {
                        if (m.numarMasa == r.masa.numarMasa)
                        {
                            r.masa = m;
                            m.disponibilitate = false; // marcheaza ca ocupata
                            break;
                        }
                    }

                    foreach (Ospatar o in listaOspatari)
                    {
                        if (o.id == r.ospatar.id)
                        {
                            r.ospatar = o;
                            break;
                        }
                    }
                }

                // refacem lista meselor disponibile
                ActualizeazaComboBoxuri(); 
                buttonAdaugareRezervare.Text = "&Adaugă rezervare(" + rezervari.Count + ")";
               
                //actualizare listbox dupa deserializare
                IstoricRezervari.Items.Clear();
                foreach (Rezervare r in rezervari)
                    IstoricRezervari.Items.Add(r);

                 MessageBox.Show("Fișierul a fost deserializat cu succes.", "rezervari.json");

            }
            else
            {
                MessageBox.Show("Fișierul rezervari.json nu există!");
            }
        }

        private void buttonHelpInstructiuni_Click(object sender, EventArgs e)
        {
                string instructiuni = "Daca te intrebi de ce nu apare nimic in lista de la masa si ospatar,\n"+
            " trebuie sa urmaresti instructiunile de mai jos: \n"+
             " \n" +
            "1) Pentru a incarca lista cu mese, apesi pe butonul editeaza masa, dai vizualizare lista mese, apoi click dreapta pe lista, deserialize, JSON, si revii la rezervari.\n " +
            "Daca vei apasa pe sageata de la lista pentru mese din rezervari vei observa ca va aparea lista cu mese.\n"+
             " \n" +
            "2) Pentru a incarca lista cu ospatari, apesi pe butonul editeaza ospatar, dai vizualizare lista ospatari, apoi click dreapta pe lista, deserialize, JSON, si revii la rezervari.\n " +
            "Daca vei apasa pe sageata de la lista pentru ospatari din rezervari vei observa ca va aparea lista cu ospatari.\n" +
             " \n" +
            "3)Finalizezi rezervarea.\n YEYEYEYEEYY!!! :)\n"+
            "\n\n"+
            "De asemenea, pentru accesarea graficelor, apesi pe Vizualizare grafice, apoi selectezi garficul dorit, dai genereaza grafic, iar daca doresti, il si poti tipari in format pdf.\n"+
            "Pentru a face asta trebui sa apesi pe tipareste grafic, apoi in coltul din stanga sus vei observa un icon in forma de imprimanta pe care trebuie sa apesi pt a forma documentul pdf.\n"+
            "\n"+
            "Iar daca nu esti iubitor de mov :), ai optiunea de a schimba culorile graficelor dand click dreapta pe pagina unde se genereaza graficul, iar apoi poti alege sa schimbi culoarea\n"+
            "pentru una sau mai multe componente ale graficelor, sau chiar sa schimbi si fontul.\n"+
            "\n"+
            "In plus, pentru partea de vizualizarea mai in detaliu unei rezervari, trebuie sa "+
            "apesi click stanga/dreapta pe rezervarea dorita, tii apasat pe mouse si tragi in chenarul corespunzator.\n"+
            "\n\n"+
            "That's all for now, folks! :)";

            MessageBox.Show(instructiuni);
        }

        //accesare grafic rezervari/zi
        private void graficRezervăriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //grupam rezervarile pe zi in functie de data
            Dictionary<DateTime, int> rezervariPeZi = new Dictionary<DateTime, int>();

            foreach(var r in rezervari)
            {
                DateTime zi = r.data_si_ora.Date;//convertim data si ora in zi

                if (rezervariPeZi.ContainsKey(zi))//verificam daca exista rezervari create in ziua curenta
                    rezervariPeZi[zi]++;//daca da, incrementam numarul de rezervari pentru acea zi
                else
                    rezervariPeZi[zi] = 1;//daca nu, inseamna ca este prima rezervare pentru acea zi si adaugam ziua in dictionar ca o cheie noua => nr rezervari=1
            }

            int[] v = new int[rezervariPeZi.Count];//valorile sunt reprezentate de nr de rezervari realizate in fiecare zi
            //dimensiunea vectorului este data de nr de zile distincte in care au fost efectuate rezervari 
            string[] etichete = new string[rezervariPeZi.Count];//etichetele afiseaza zilele in care s-au efectuat rezervari 
            int nrElem = v.Length;//numarul de zile creat pt a fi folosit la dimensionarea graficului

            int i = 0;//index pt parcurgerea vectorilor cu valori si etichete
            foreach(var kvp in rezervariPeZi.OrderBy(x => x.Key))//parcurgem dictionarul rezervariPeZi ordonat dupa zile, pt a ordona cronologic zilele
            {
                v[i] = kvp.Value;//stocam nr de rezervari in vectorul v
                etichete[i] = kvp.Key.ToString("dd.MM");//stocam ziua in vectorul etichete ca un string in formatul introdus
                i++;//incrementam indexul pt urmatoarea pereche zi-rezervari
            }

            //apelam form5 prin vectorul care contine numarul de rezervari, vectorul cu zile si titlu graficului ce va aparea in bara form-ului 
            Form5 frm5 = new Form5(v, etichete, "Rezervari realizate pe zi:");
            frm5.Show();
        }

        //accesare grafic ospatari/tura
        private void graficOspătariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //grupam ospatarii pe ture, tura este de tip string :)
            Dictionary<string, int> ospatariPeTura = new Dictionary<string, int>();

            foreach(var r in rezervari)
            {
                string tura = r.ospatar.tura.ToString();//accesam tura ospatarului asociat rezervarii curente si o convertim la string

                if (ospatariPeTura.ContainsKey(tura))//verificam daca sunt distribuiti ospatari pt tura selectata drept cheie in dictionar
                    ospatariPeTura[tura]++;//daca da, incrementam numarul de ospatari pt acea tura
                else
                    ospatariPeTura[tura] = 1;//daca nu, inseamna ca pt acea tura tocmai a fost atribuit primul ospatar
                //adaugam tura in dictionar ca o cheie noua si setam nr de ospatari cu 1
            }

            int[] v = new int[ospatariPeTura.Count];//valorile sunt reprezentate de nr de ospatari pt fiecare tura
            //dimensiunea vectiorului este data de nr de ture distincte (in cazul nostru 3)
            string[] etichete = new string[ospatariPeTura.Count];//se stocheaza numele turelor pt grafic
            int nrElem = v.Length;//nr total de ture pt a folosi la dimensionarea graficului ( se vor crea 3 bare -> vezi cod Form6 )

            //proces asemanator cu cel de la rezervari
            int i = 0;
            foreach(var kvp in ospatariPeTura.OrderBy(x=>x.Key))
            {
                v[i] = kvp.Value;
                etichete[i] = kvp.Key.ToString();
                i++;
            }

            Form6 frm6 = new Form6(v, etichete, "Ospatari repartizati pe tura:");
            frm6.Show();
        }

        //accesare grafic mese/zi
        private void graficMeseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cream un dictionar pentru a stoca zilele ca chei si o colectie de numere de mese ocupate (HashSet pentru a evita duplicatele) ca valori
            Dictionary<DateTime, HashSet<int>> meseOcupatePeZi = new Dictionary<DateTime, HashSet<int>>();

            foreach(var r in rezervari)
            {
                DateTime zi = r.data_si_ora.Date;

                //verificam daca ziua curenta nu exista deja ca o cheie in dictionarul meseOcupatePeZi
                if (!meseOcupatePeZi.ContainsKey(zi))
                    //daca ziua nu exista, cream o noua zi drept cheie
                    //si un nou HashSet gol ca valoare in care vom stoca numerele unice ale meselor ocupate in acea zi
                    meseOcupatePeZi[zi] = new HashSet<int>();

                //adaugam numarul mesei din rezervarea curenta in HashSet pt ziua respectiva
                meseOcupatePeZi[zi].Add(r.masa.numarMasa);
            }

            int[] v = new int[meseOcupatePeZi.Count];//stocam numarul de mese diferite ocupate in fiecare zi
            //dimensiunea vectorului este data de numarul de zile distincte pentru care avem mese ocupate
            string[] etichete = new string[meseOcupatePeZi.Count];//stocam etichetele care afiseaza zilele in care au fost ocupate mese
            int nrElem = v.Length;//nr de zile distincte  folosit pt dimensionarea graficului

            //proces asemantor cu cel de la rezervari
            int i = 0;
            foreach(var kvp in meseOcupatePeZi.OrderBy(x=>x.Key))
            {
                v[i] = kvp.Value.Count;
                etichete[i] = kvp.Key.ToString("dd.MM");
                i++;
            }

            Form7 frm7 = new Form7(v, etichete, "Mese diferite ocupate pe zi:");
            frm7.Show();
        }

        //drag & drop 

        //selectare rezervare din lista, avand in vedere ca este o lista trebuie sa ne folosim de SelectedItem pt a accesa rezervarile din lista
        private void IstoricRezervari_MouseDown(object sender, MouseEventArgs e)
        {
            if (IstoricRezervari.SelectedItem == null)
                return;

            DragDropEffects rezultat = DragDropEffects.None;

            object elementSelectat = IstoricRezervari.SelectedItem;

            if (e.Button == MouseButtons.Left)
                rezultat = IstoricRezervari.DoDragDrop(elementSelectat, DragDropEffects.Copy);

            if (e.Button == MouseButtons.Right)
                rezultat = IstoricRezervari.DoDragDrop(elementSelectat, DragDropEffects.Move);

            if (rezultat == DragDropEffects.Move)
                IstoricRezervari.Items.Remove(elementSelectat);

        }

        private void lblDragLeave(object sender, EventArgs e)
        {
            lblRezervareSelectata.Text = "Nu ai tras rezervarea in interiorul chenarului!";
        }

        private void lblDragOver(object sender, DragEventArgs e)
        {
            lblRezervareSelectata.Text = "Posibil drop!!!";
        }

        private void lblDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Rezervare)))
            { 
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Rezervare)))
            {
                Rezervare rez = (Rezervare)e.Data.GetData(typeof(Rezervare));
                lblRezervareSelectata.Text = rez.ToString();
            }
        }

        //accesare pagina login
        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
        }

    }

    //CLASE SI CONSTRUCTORI
    public class Rezervare
    {
        public int idRezervare { get; set; }
        public string numeClient { get; set; }
        public DateTime data_si_ora { get; set; }
        public int numarPersoane { get; set; }
        public Masa masa { get; set; }
        public Ospatar ospatar { get; set; }

        public Rezervare()
        {
            idRezervare = 0;
            numeClient = "";
            numarPersoane = 0;
        }

        public Rezervare(int idRezervare, string numeClient, DateTime data_si_ora, int numarPersoane, Masa masa, Ospatar ospatar)
        {
            this.idRezervare = idRezervare;
            this.numeClient = numeClient;
            this.data_si_ora = data_si_ora;
            this.numarPersoane = numarPersoane;
            this.masa = masa;
            this.ospatar = ospatar;
        }

        public override string ToString()
        {
            return "Rezervare - ID rezervare: "+idRezervare+", Nume client: "+numeClient+", Data si ora: "+data_si_ora+", Numar persoane: "+numarPersoane+", Masa: "+masa+", Ospatar: "+ospatar;
        }
    }
}
