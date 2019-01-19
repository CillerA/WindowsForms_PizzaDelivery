using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abduraman_Ciller_faza2_1039
{
    public partial class Form7 : Form
    {
        int y = 0;
        public Form7()
        {
            InitializeComponent();
            y = panel1.Height - 10; 
          
           
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(DataFormats.Text).ToString();
            Graphics g = Graphics.FromHwnd(panel1.Handle);     
            g.DrawString(text, this.Font, new SolidBrush(Color.Black), 10, y);
            y -= 20;   
            //if (y >= panel1.Height)
                if(y<=0)   //umplere de jos in sus
                MessageBox.Show("Nu mai exista spatiu");
            if (e.Effect == DragDropEffects.Move)
                textBox1.Clear();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None; 
            if ((e.KeyState & 8) == 8   // verificare daca e apasat ctrl
                && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

       


    }
}
