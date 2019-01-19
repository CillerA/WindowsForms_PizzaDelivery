using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abduraman_Ciller_faza2_1039
{
    public partial class Form3 : Form      
    {
        ArrayList lista2;

        public Form3(ArrayList nou)
        {
            InitializeComponent();
             lista2 = nou;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Pizza p in lista2)
            {
                textBox1.Text += p.ToString() + Environment.NewLine;
            }
        }
    }
}
