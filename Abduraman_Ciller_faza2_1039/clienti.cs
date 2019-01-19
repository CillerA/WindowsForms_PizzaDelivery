using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abduraman_Ciller_faza2_1039
{
    class Clienti:ICloneable, IComparable
    {
         private string nume;
        private string prenume;
        private int nrTelefon;
        private Adrese adresa;


        //constructor implicit
        public Clienti()
        {
            nume = "Anonim";
            prenume = "Anonim";
            nrTelefon = 0;
            adresa = null;
        }

        //constructor explicit 
        public Clienti(string n, string p, int nr, Adrese a)
        {
            nume = n;
            prenume = p;
            nrTelefon = nr;
            adresa = a;
        }

        //proprietate pentru nume 
        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }

        //proprietate pentru prenume 
        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value != null)
                    prenume = value;
            }
        }

        //proprietate pentru nrTelefon 
        public int NrTelefon
        {
            get { return nrTelefon; }
            set
            {
                if (value > 0)
                    nrTelefon = value;
            }
        }

        //proprietate pentru adresa 
        public Adrese Adresa
        {
            get { return adresa; }
            set
            {
                adresa = value;
            }
        }


        public override string ToString()
        {
            string result = "Clientul cu numele " + nume + " si prenumele " + prenume + " are numarul de telefon " + nrTelefon + " si urmatoarea adresa  " + adresa;
            return result;

        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Clienti c = (Clienti)obj;
            if (String.Compare(nume, c.nume) < 0)
                return -1;
            else if (String.Compare(nume, c.nume) == 0)
                return 1;
            else
                return string.Compare(prenume, c.prenume);
        }
    }
    }

