using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Activitatea_unui_restaurant
{
    public partial class Form8: Form
    {
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=c:\\Users\\maria\\source\\repos\\Activitatea_unui_restaurant\\Restaurant.accdb";

        //vectori valori tabela ospatari
        string[] lNume = {"Ionescu", "Popescu", "Georgescu", "Dima", "Stoica", "Marin", "Tudor", "Radu", "Matei", "Enache",
                            "Dragomir", "Vlad", "Neagu", "Petrescu", "Barbu", "Badea", "Lupu", "Stan", "Toma", "Avram"};

        string[] lPrenume = {"Andrei", "Maria", "Elena", "Mihai", "Larisa", "Ion", "Bianca", "Cristina", "Alexandru", "Silvia",
                                "Ana", "Paul", "Andreea", "Radu", "Corina", "Miruna", "Victor", "Teodora", "Sorin", "Claudia"};

        string[] lTura = {"Dimineata","DupaAmiaza","Seara"};

        //vectori valori tabela mese
        int[] lNrLocuri = {2, 3, 4, 5, 6, 7, 8};

        bool[] lDisponibilitate = {true, false};

        //vectori valori tabela meniuri
        string[] lDenumire = {"Apa plata", "Burger", "Cheesecake", "Ciorba de burta", "Clatite", "Cola", "Espresso", "Frappe", "Friptura de porc", "Inghetata",
                                    "Limonada", "Papanasi", "Paste carbonara", "Risotto", "Sarmale", "Supa de pui", "Tiramisu", "Vin rosu"};

        string[] lTip = {"Bautura", "Mancare", "Desert"};

        int[] lPret = { 5, 6, 7, 10, 12, 14, 18, 20, 22, 25, 30, 33, 35, 40};

        public Form8()
        {
            InitializeComponent();
        }


        //tab ospatari
        private void btn_Select_ospatari_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from Ospatari";
                cmd.Connection = conexiune;
                OleDbDataReader cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                {
                    ListViewItem item = new ListViewItem(cmdReader["ID ospatar"].ToString());
                    item.SubItems.Add(cmdReader["Nume"].ToString());
                    item.SubItems.Add(cmdReader["Prenume"].ToString());
                    item.SubItems.Add(cmdReader["Tura"].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btn_Insert_ospatari_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            OleDbConnection cnn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select max([ID ospatar]) from Ospatari";
                int ID_ospatar = Convert.ToInt32(cmd.ExecuteScalar()); 

                cmd.CommandText = "insert into Ospatari values(?,?,?,?)";
                cmd.Parameters.Add("ID ospatar", OleDbType.Integer).Value = ID_ospatar + 1;
                cmd.Parameters.Add("nume", OleDbType.Char, 30).Value = lNume[rnd.Next(lNume.Length)];
                cmd.Parameters.Add("prenume", OleDbType.Char, 30).Value = lPrenume[rnd.Next(lPrenume.Length)];
                cmd.Parameters.Add("tura", OleDbType.Char, 10).Value = lTura[rnd.Next(lTura.Length)];
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_ospatari_Click(sender, e);
            }
        }

        private void btn_Update_ospatari_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string strTura = lTura[rnd.Next(lTura.Length)];

            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView1.Items)
                    if (item.Checked)
                    {
                        int ID_ospatar = Convert.ToInt32(item.SubItems[0].Text);
                        cmd.CommandText = "update Ospatari set tura='" + strTura + "' where [ID ospatar]=" + ID_ospatar;
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_ospatari_Click(sender, e);
            }
        }

        private void btn_Delete_ospatari_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView1.Items)
                    if (item.Checked)
                    {
                        int ID_ospatar = Convert.ToInt32(item.SubItems[0].Text);
                        cmd.CommandText = "delete from Ospatari where [ID ospatar]=" + ID_ospatar;
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_ospatari_Click(sender, e);
            }
        }
        
        
        //tab mese
        private void btn_Select_mese_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from Mese";
                cmd.Connection = conexiune;
                OleDbDataReader cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                {
                    ListViewItem item = new ListViewItem(cmdReader["Numar masa"].ToString());
                    item.SubItems.Add(cmdReader["Numar locuri"].ToString());
                    item.SubItems.Add(cmdReader["Disponibilitate"].ToString());
                    listView2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btn_Insert_mese_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            OleDbConnection cnn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select max([Numar masa]) from Mese";
                int nrMasa = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "insert into Mese values(?,?,?)";
                cmd.Parameters.Add("Numar masa", OleDbType.Integer).Value = nrMasa + 1;
                cmd.Parameters.Add("numar locuri", OleDbType.Integer).Value = lNrLocuri[rnd.Next(lNrLocuri.Length)];
                cmd.Parameters.Add("disponibilitate", OleDbType.Boolean).Value = lDisponibilitate[rnd.Next(lDisponibilitate.Length)];
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_mese_Click(sender, e);
            }
        }

        private void btn_Update_mese_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool beDisponibilitate = lDisponibilitate[rnd.Next(lDisponibilitate.Length)];

            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView2.Items)
                    if (item.Checked)
                    {
                        int nrMasa = Convert.ToInt32(item.SubItems[0].Text);
                        cmd.CommandText = "UPDATE Mese SET disponibilitate = ? WHERE [Numar masa] = ?";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("?", beDisponibilitate);
                        cmd.Parameters.AddWithValue("?", nrMasa);
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_mese_Click(sender, e);
            }
        }

        private void btn_Delete_mese_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView2.Items)
                    if (item.Checked)
                    {
                        int nrMasa = Convert.ToInt32(item.SubItems[0].Text);
                        cmd.CommandText = "delete from Mese where [Numar masa]=" + nrMasa;
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_mese_Click(sender, e);
            }
        }

        //tab meniuri
        private void btn_Select_meniuri_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();

            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from Meniuri";
                cmd.Connection = conexiune;
                OleDbDataReader cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                {
                    ListViewItem item = new ListViewItem(cmdReader["Denumire"].ToString());
                    item.SubItems.Add(cmdReader["Tip"].ToString());
                    item.SubItems.Add(cmdReader["Pret"].ToString());
                    listView3.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
        
        private void btn_Insert_meniuri_Click(object sender, EventArgs e)
        {
            string denumire = ucAdaugareProdus1.Denumire();
            string tip = ucAdaugareProdus1.Tip();
            int pret = ucAdaugareProdus1.Pret();


            if (string.IsNullOrEmpty(denumire))
            {
                MessageBox.Show("Introduceți o denumire validă.");
                return;
            }

            OleDbConnection cnn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandText = "SELECT COUNT(*) FROM Meniuri WHERE [Denumire]=?";
                cmd.Parameters.AddWithValue("?", denumire);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Produsul există deja.");
                    return;
                }

                cmd.CommandText = "INSERT INTO Meniuri VALUES (?, ?, ?)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("?", denumire);
                cmd.Parameters.AddWithValue("?", tip);
                cmd.Parameters.AddWithValue("?", pret);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produs adăugat.");


                ucAdaugareProdus1.ReseteazaCampuri();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_meniuri_Click(sender, e);
            }
        }
        
        private void btn_Update_meniuri_Click(object sender, EventArgs e)
        {
            int pretNou= ucAdaugareProdus1.PretNou();

            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView3.Items) 
                    if (item.Checked)
                    {
                        string denumire = item.SubItems[0].Text; 

                        cmd.CommandText = "UPDATE Meniuri SET Pret = ? WHERE Denumire = ?";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("?", pretNou);
                        cmd.Parameters.AddWithValue("?", denumire);
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_meniuri_Click(sender, e);
            }
        }

        private void btn_Delete_meniuri_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection(connString);
            try
            {
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;

                foreach (ListViewItem item in listView3.Items)
                    if (item.Checked)
                    {
                        string denumire = item.SubItems[0].Text;
                        cmd.CommandText = "DELETE FROM Meniuri WHERE [Denumire] = '" + denumire + "'";
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                btn_Select_meniuri_Click(sender, e);
            }
        }

        
    }
}
