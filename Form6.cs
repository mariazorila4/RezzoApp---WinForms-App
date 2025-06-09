using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activitatea_unui_restaurant
{
    public partial class Form6: Form
    {
        //vector pt elemente si etichete, titlu form si nr elemente
        int[] valori;
        string[] etichete;
        string titlu;
        int nrElem;

        //culori
        Color chenarGraficO;
        Color chenarValoriO;
        Color culoareTextO;
        Color culoareValoriO;
        Color culoareTrendLineO;

        //font 
        Font font = new Font(FontFamily.GenericSansSerif, 10);

        //margine
        int margine;

        //constructor form care ia parametrii din form1
        public Form6(int[] v, string[] etichete, string titlu)
        {
            InitializeComponent();
            this.valori = v;
            this.etichete = etichete;
            this.Text = titlu;//pt a aparea titlul in bara form-ului
            this.nrElem = valori.Length;
        }

        private void genToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //culori
            chenarGraficO = Color.MediumBlue;
            chenarValoriO = Color.LightPink;
            culoareTextO = Color.DarkBlue;
            culoareValoriO = Color.DarkCyan;
            culoareTrendLineO = Color.Purple;

            //margine
            margine = 30;

            //redesenare grafic
            panel1.Invalidate();
        }

        private void panelPaint(object sender, PaintEventArgs e)
        {
            deseneazaGraficOspatari(e.Graphics, panel1.ClientRectangle.X, panel1.ClientRectangle.Y, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);
        }

        void deseneazaGraficOspatari(Graphics gr, int x, int y, int w, int h)
        {
            if (nrElem > 0)
            {
                //chenar principal
                Pen penCP = new Pen(chenarGraficO, 3);
                Rectangle rectCP = new Rectangle(x + margine,
                                                y + 2 * margine,
                                                w - 2 * margine,
                                                h - 3 * margine);
                gr.DrawRectangle(penCP, rectCP);

                //bare grafic
                double latime = rectCP.Width / nrElem / 2;
                double distanta = (rectCP.Width - nrElem * latime) / (nrElem + 1);

                //chenar bare
                Pen ChB = new Pen(chenarValoriO, 5);

                //pensula bare
                Brush brB = new SolidBrush(culoareValoriO);
                Brush brT = new SolidBrush(culoareTextO);

                //desenare trend line
                double medie = valori.Average();
                int inaltimeMedie = rectCP.Height * (int)medie / valori.Max();
                int yTrend = rectCP.Top + rectCP.Height - inaltimeMedie;

                Pen penTrend = new Pen(culoareTrendLineO, 2)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
                };
                gr.DrawLine(penTrend, rectCP.Left, yTrend, rectCP.Right, yTrend);

                gr.DrawString("Medie: " + medie.ToString("0.0"), font, brT,
                                new Point(rectCP.Left + 5, rectCP.Top - 50));

                //desenare dreptunghiuri
                Rectangle[] rectangles = new Rectangle[nrElem];
                for(int i = 0; i < nrElem; i++) 
                {

                    rectangles[i] = new Rectangle((int)(rectCP.Location.X + i * latime + (i + 1) * distanta),
                                                    rectCP.Location.Y + rectCP.Height - rectCP.Height * valori[i] / valori.Max(),
                                                    (int)latime, rectCP.Height * valori[i]/valori.Max());
                    gr.DrawRectangle(ChB, rectangles[i]);

                    //text
                    gr.DrawString(valori[i].ToString(), font, brT,
                                 new Point(rectangles[i].Location.X, rectangles[i].Location.Y-font.Height));

                    //eticheta sub bara
                    gr.DrawString(etichete[i], font, brT,
                          new Point(rectangles[i].Location.X, rectangles[i].Bottom + 2));
                }
                gr.FillRectangles(brB, rectangles);   
                        
            }
        }

        private void tipăreșteGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            deseneazaGraficOspatari(e.Graphics,
                                    e.PageBounds.X,
                                    e.PageBounds.Y,
                                    e.PageBounds.Width,
                                    e.PageBounds.Height);
        }

        private void schimbăFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            panel1.Invalidate();
        }

        private void chenarGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                chenarGraficO = dlg.Color;
            panel1.Invalidate();

        }

        private void chenarBareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                chenarValoriO = dlg.Color;
            panel1.Invalidate();

        }

        private void bareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoareValoriO = dlg.Color;
            panel1.Invalidate();

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoareTextO = dlg.Color;
            panel1.Invalidate();

        }
    }
}
