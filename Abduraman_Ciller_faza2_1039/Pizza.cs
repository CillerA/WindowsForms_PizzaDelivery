using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abduraman_Ciller_faza2_1039
{
    class Pizza: ICloneable, IComparable
    {
         private string denumire;
        private string[] ingrediente;
        private float pret;

        //constructor implicit
        public Pizza()
        {
            denumire = "Default pizza";
            ingrediente = null;
            pret = 0.0f;
        }

        //constructor explicit 
        public Pizza(string den, string[] ingr, float p)
        {
            denumire = den;
            ingrediente = new string[ingr.Length];
            for (int i = 0; i < ingr.Length; i++)
                ingrediente[i] = ingr[i];
            pret = p;
        }

        //proprietate pentru denumire 
        public string Denumire
        {
            get { return denumire; }
            set
            {
                if (value != null)
                    denumire = value;
            }
        }

        //proprietate pentru vectorul de ingrediente
        public string[] Ingrediente
        {
            get { return ingrediente; }
            set { ingrediente = value; }
        }

        //proprietate pentru pret 
        public float Pret
        {
            get { return pret; }
            set
            {
                if (pret > 0)
                    pret = value;
            }
        }

        public override string ToString()
        {
            string result = "Pizza " + denumire + " are pretul " + pret + " si urmatoarele ingrediente: ";
            for (int i = 0; i < ingrediente.Length; i++)
                result += ingrediente[i] + " ";
            return result;

        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Pizza Clone()
        {
            string[] ingredienteNoi = (string[])ingrediente.Clone(); //deep copy pe vectorul de ingrediente
            Pizza p = (Pizza)((ICloneable)this).Clone();
            p.ingrediente = ingredienteNoi; //shallow copy
            return p;
        }

        //interfata CompareTo sorteaza mai intai dupa pret, dupa care dupa denumire
        public int CompareTo(object obj)
        {
            Pizza p = (Pizza)obj;
            if (this.pret < p.pret)
                return -1;
            else
                if (this.pret > p.pret)
                return 1;
            else
                return string.Compare(this.denumire, p.denumire);
        }

        //supraincarcarea operatorului + pentru adaugarea de ingrediente noi in vector
        public static Pizza operator +(Pizza p, string n)
        {
            Pizza copie = (Pizza)p.Clone();
            if (copie.ingrediente != null)
            {
                string[] ingredienteNoi = new string[p.ingrediente.Length + 1]; // se aloca memorie pentru vectorul ingredienteNoi
                copie.ingrediente.CopyTo(ingredienteNoi, 0); //copiaza in ingredienteNoi toate elementele din vectorul ingrediente, incepand cu pozitia 0 
                ingredienteNoi[ingredienteNoi.Length - 1] = n; //se adauga ingredientul nou n pe ultima pozitie
                copie.ingrediente = ingredienteNoi;
            }
            else
            {
                copie.ingrediente = new string[1];
                copie.ingrediente[0] = n;
            }
            return copie;
        }

        //index
        public string this[int index]
        {
            get
            {
                if (index > 0 && index < this.ingrediente.Length)
                    return this.ingrediente[index];
                else
                    return null;
            }
        }

    }

    }

