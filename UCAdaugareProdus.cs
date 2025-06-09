using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Activitatea_unui_restaurant
{
    public partial class UCAdaugareProdus: UserControl
    {

        string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=c:\\Users\\maria\\source\\repos\\Activitatea_unui_restaurant\\Restaurant.accdb";

        public UCAdaugareProdus()
        {
            InitializeComponent();

            comboBoxTip.Items.AddRange(new string[] { "Mancare", "Bautura", "Desert" });
            comboBoxTip.SelectedIndex = -1;
        }

        public string Denumire() { return txtDenumire.Text.Trim(); }
        public string Tip() { return comboBoxTip.SelectedItem?.ToString() ?? ""; }
        public int Pret() { return (int)numericPret.Value; }
        public int PretNou()
        {
            try
            {
                return Convert.ToInt32(txtPretNou.Text.Trim());
            }
            catch
            {
                return -1; 
            }
        }


        public void ReseteazaCampuri()
        {
            txtDenumire.Clear();
            comboBoxTip.SelectedIndex = 0;
            numericPret.Value = numericPret.Minimum;
            txtPretNou.Clear();
        }



    }


}


