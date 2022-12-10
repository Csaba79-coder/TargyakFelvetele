using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargyakFelvetele
{
    public class Hallgato
    {
        string nev;
        string neptun;
        string jelszo;

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

        public string Jelszo
        {
            get
            {
                return jelszo;
            }

            set
            {
                jelszo = value;
            }
        }

        public Hallgato(string nev, string neptun, string jelszo)
        {
            this.Nev = nev;
            this.Neptun = neptun;
            this.Jelszo = jelszo;
        }
    }
}
