using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargyakFelvetele
{
    class Targy
    {
        string nev;
        string neptun;
        int kredit;

        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        public string Neptun
        {
            get
            {
                return neptun;
            }

            set
            {
                neptun = value;
            }
        }

        public int Kredit
        {
            get
            {
                return kredit;
            }

            set
            {
                kredit = value;
            }
        }

        public Targy(string nev, string neptun, int kredit)
        {
            this.Nev = nev;
            this.Neptun = neptun;
            this.Kredit = kredit;
        }
    }
}
