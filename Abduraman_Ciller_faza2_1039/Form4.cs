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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //adaugare client
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fisier = new FileStream("clienti.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fisier);
            sw.Write(textbox_nume.Text);
            sw.Write(textbox_prenume.Text);
            sw.Write(textbox_telefon.Text);
            sw.Write(textbox_sector.Text);
            sw.Write(textbox_strada.Text);
            sw.Write(textbox_numar.Text);
            sw.Write(textbox_bloc.Text);
            sw.Write(textbox_scara.Text);
            sw.Write(textbox_etaj.Text);
            sw.Write(textbox_apartament.Text);

            sw.Close();
            fisier.Close();
            MessageBox.Show("Client nou adaugat");

            textbox_nume.Clear();
            textbox_prenume.Clear();
            textbox_telefon.Clear();
            textbox_sector.Clear();
            textbox_strada.Clear();
            textbox_numar.Clear();
            textbox_bloc.Clear();
            textbox_scara.Clear();
            textbox_etaj.Clear();
            textbox_apartament.Clear();

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }
    }
}
