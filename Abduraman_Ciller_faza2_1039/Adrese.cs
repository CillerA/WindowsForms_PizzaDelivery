using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abduraman_Ciller_faza2_1039
{
    class Adrese:ICloneable
    {
          private int sector;
       private string strada;
       private int nr;
       private string bloc;
       private char scara;
       private int etaj;
       private int apartament;

        //constructor implicit
        public Adrese()
        {
            sector = 0;
            strada = "Anonima";
            nr = 0;
            bloc = "ABC";
            scara = 'A';
            etaj = 0;
            apartament = 0;

        }

        //constructor explicit
        public Adrese(int se, string st, int n, string b, char sc, int e, int a)
        {
            sector = se;
            strada = st;
            nr = n;
            bloc = b;
            scara = sc;
            etaj = e;
            apartament = a;
        }

        //proprietate pentru sector 
        public int Sector
        {
            get { return sector; }
            set
            {
                if (sector > 0)
                    sector = value;
            }
        }


        //proprietate pentru strada 
        public string Strada
        {
            get { return strada; }
            set
            {
                if (value != null)
                    strada = value;
            }
        }

        //proprietate pentru nr 
        public int Nr
        {
            get { return nr; }
            set
            {
                if (nr > 0)
                    nr = value;
            }
        }

        //proprietate pentru bloc 
        public string Bloc
        {
            get { return bloc; }
            set
            {
                if (value != null)
                    bloc = value;
            }
        }

        //proprietate pentru scara 
        public char Scara
        {
            get { return scara; }
            set
            {
                if (value != null)
                    scara = value;
            }
        }

        //proprietate pentru etaj 
        public int Etaj
        {
            get { return etaj; }
            set
            {
                if (etaj > 0)
                    etaj = value;
            }
        }

        //proprietate pentru apartament 
        public int Apartament
        {
            get { return apartament; }
            set
            {
                if (apartament > 0)
                    apartament = value;
            }
        }



        public override string ToString()
        {
            string result = "Clientul are urmatoarea adresa:  " + "sector " + sector + " strada " + strada + " numar " + nr + " bloc " + bloc + " scara " + scara + "etaj " + etaj + " apartament " + apartament;  
            return result;

        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

    }
    }

