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

namespace Abduraman_Ciller_faza2_1039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //afisare meniu
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fisier = new FileStream("pizza.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fisier);
            string s = sr.ReadToEnd();
            textBox1.Lines = File.ReadAllLines("pizza.txt");
            sr.Close();
            fisier.Close();
        }

        //adauga pizza
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void informatiiAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie realizata de Abduraman Ciller Melis pentru gestionarea eficienta a unui business de tip Pizza Delivery", "Mesaj", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void iesireDinAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                menuStrip1.BackColor = dialog.Color;
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                menuStrip1.Font = dialog.Font;
        }
    }
}
