using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activitatea_unui_restaurant
{
    public partial class Form9: Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void goClicked(object sender, EventArgs e)
        {
            this.Hide(); // ascundem fereastra curenta
            Form8 frm8 = new Form8();
            frm8.ShowDialog(); // se deschide fereastra Form2
            this.Show();
        }
    }
}
