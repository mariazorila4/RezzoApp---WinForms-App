using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace Activitatea_unui_restaurant
{
    public partial class UCLoginBazaDate: UserControl
    {

        public string UserName = "";
        string[,] credentiale = { { "angajat101", "111" }, { "angajat102", "222" }, { "angajat103", "333" } ,{ "angajat104","444"} }; 

        public UCLoginBazaDate()
        {
            InitializeComponent();
        }

        public event EventHandler btngoClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < credentiale.GetLength(0); i++)
            {
                if (credentiale[i, 0] == txtUser.Text)
                {
                    if (credentiale[i, 1] == txtPassword.Text)
                    {
                        MessageBox.Show("Utilizatorul " + txtUser.Text + " este conectat!");

                        UserName = txtUser.Text;

                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();

                        btngoClicked?.Invoke(this, e); 
                    }
                    else
                    {
                        MessageBox.Show("Detalii incorecte - incercati din nou!"); 
                    }

                    return;
                }
            }
            MessageBox.Show("Eroare - incercati din nou!"); 
        }
    }
}
