using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        ArrayList listaTb = new ArrayList();
        ArrayList nou = new ArrayList();
        public Form2()
        {
            InitializeComponent();
            listaTb.Add(textbox_denumire);
            listaTb.Add(textbox_ingrediente);
            listaTb.Add(textbox_pret);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = ((TextBox)listaTb[0]).Location.X;
            int y = ((TextBox)listaTb[listaTb.Count - 1]).Location.Y;
            int distanta = ((TextBox)listaTb[1]).Location.X - ((TextBox)listaTb[0]).Location.X;

            for (int i = 0; i < 3; i++)
            {
                TextBox boxNou = new TextBox();
                boxNou.Location = new Point(x, y + 50);
                x += distanta;
                if (i == 3) boxNou.ReadOnly = true;
                listaTb.Add(boxNou);
                this.Controls.Add(boxNou);
            }

            for (int i = 0; i < listaTb.Count; i += 3)   //pentru a nu introduce litere in campul de pret
            {
                ((TextBox)listaTb[i + 2]).KeyPress += new KeyPressEventHandler(textbox_pret_KeyPress);

            }
        }

           private void textbox_pret_KeyPress(object sender, KeyPressEventArgs e)  
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;

        }

           private void button1_Click(object sender, EventArgs e)
           {
               //FileStream fisier = new FileStream("all.txt", FileMode.Append, FileAccess.Write);
               //StreamWriter sw = new StreamWriter(fisier);
               //sw.Write(textbox_denumire.Text);
               //sw.Write(textbox_ingrediente.Text);
               //sw.Write(textbox_pret.Text);
               //sw.Close();
               //fisier.Close();
               //MessageBox.Show("Noul tip de pizza a fost introdus");

               //FileStream fisier2 = new FileStream("pizza.txt", FileMode.Create, FileAccess.Write);
               //StreamWriter sw2 = new StreamWriter(fisier2);
               //sw2.Write(textbox_denumire.Text);
               //sw2.Close();
               //fisier2.Close();

               bool valid = false;

               for (int i = 0; i < listaTb.Count; i += 4)
               {
                   if (((TextBox)listaTb[i]).Text == "")
                   {
                       valid = true;
                       errorProvider1.SetError((TextBox)listaTb[i], "Nu ati introdus denumirea pizzei");
                   }
                   else if (((TextBox)listaTb[i + 1]).Text == "")
                   {
                       valid = true;
                       errorProvider1.SetError((TextBox)listaTb[i + 1], "Nu ati introdus ingredientele:");
                   }
                   else if (((TextBox)listaTb[i + 2]).Text == "")
                   {
                       valid = true;
                       errorProvider1.SetError((TextBox)listaTb[i + 2], "Nu ati introdus pretul:");
                   }

               }
               if (valid == false)
               {

                   for (int i = 0; i < listaTb.Count; i += 3)
                   {
                       string denumire = ((TextBox)listaTb[i]).Text;
                       string[] ingredienteS = textbox_ingrediente.Text.Split(',');
                       string[] ingrediente = new string[ingredienteS.Length];
                       for (int j = 0; j < ingredienteS.Length;  j++)
                           ingrediente[i] = ((TextBox)listaTb[i + 1]).Text;
                       float pret = (float)Convert.ToDouble(((TextBox)listaTb[i + 2]).Text);


                       Pizza p = new Pizza(denumire, ingrediente, pret);
                       nou.Add(p);
                       MessageBox.Show("Nou tip de pizza adaugat");
                       textbox_denumire.Clear();
                       textbox_ingrediente.Clear();
                       textbox_pret.Text = "";
                      
                      
                   }

               }
           }

           private void button3_Click(object sender, EventArgs e)
           {
               Form3 formNou = new Form3(nou); 
               formNou.ShowDialog(); 
           }
        }
    }

