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

namespace Abduraman_Ciller_faza2_1039
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pizza1 = int.Parse(textBox1.Text);
            int pizza2 = int.Parse(textBox2.Text);
            int pizza3 = int.Parse(textBox3.Text);
            int pizza4 = int.Parse(textBox4.Text);

            float totalPizza = pizza1 + pizza2 + pizza3 + pizza4;
            float deg1 = (pizza1 / totalPizza) * 360;
            float deg2 = (pizza2 / totalPizza) * 360;
            float deg3 = (pizza3 / totalPizza) * 360;
            float deg4 = (pizza4 / totalPizza) * 360;

            Pen stilou = new Pen(Color.Black, 2);

            Graphics g = this.CreateGraphics();


            Rectangle rec = new Rectangle(textBox1.Location.X + textBox1.Size.Width + 20, 60, 250, 250);

            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Chocolate);
            Brush b4 = new SolidBrush(Color.BlueViolet);


            g.Clear(Form1.DefaultBackColor);
            g.DrawPie(stilou, rec, 0, deg1);
            g.FillPie(b1, rec, 0, deg1);
            g.DrawPie(stilou, rec, deg1, deg2);
            g.FillPie(b2, rec, deg1, deg2);
            g.DrawPie(stilou, rec, deg2 + deg1, deg3);
            g.FillPie(b3, rec, deg2 + deg1, deg3);
            g.DrawPie(stilou, rec, deg3 + deg2 + deg1, deg4);
            g.FillPie(b4, rec, deg3 + deg2 + deg1, deg4);
        }

        private void previzualizareImprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.frm_print);
            PrintPreviewDialog pdlg = new PrintPreviewDialog();
            pdlg.Document = pd;
            pdlg.ShowDialog();
        }

        public void frm_print(object sender, PrintPageEventArgs e)   //printscreen
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            this.DrawToBitmap(bmp, rec);
            g.DrawImage(bmp, 0, 0);
        }

        private void salvareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Grafic salvat cu succes");
        }

     
    }
 }


