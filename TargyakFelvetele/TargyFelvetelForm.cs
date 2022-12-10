using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargyakFelvetele
{
    public partial class TargyFelvetelForm : Form 
    {
        List<Targy> felvehetoTargyak = new List<Targy>();
        List<Targy> felvettTargyak = new List<Targy>();
        Hallgato hallgato = new Hallgato("aaa","AAA","a");
        public TargyFelvetelForm(Hallgato h)
        {
            InitializeComponent();
            hallgato.Nev = h.Nev;
            hallgato.Neptun = h.Neptun;
            hallgato.Jelszo = h.Jelszo;
            label3.Text = "A hallgató neve: " + hallgato.Nev;
            label4.Text = "A hallgató Neptun kódja: " + hallgato.Neptun;
            BeolvasTargy();
            BeolvasFelvett();
        }

        void BeolvasTargy()
        {
            if (File.Exists(@"..\..\..\targyak.txt"))
            {
                StreamReader file = new StreamReader("..\\..\\..\\targyak.txt", Encoding.UTF8);
                while (!file.EndOfStream)
                {
                    Targy targy = new Targy(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine()));
                    felvehetoTargyak.Add(targy);
                    lbFelvehetoTargyak.Items.Add(targy.Nev);
                }
                file.Close();
            }
            else
                MessageBox.Show("Nem találom a targyak.txt fájlt!");
        }
       void BeolvasFelvett()
        {
            if (File.Exists(@"..\..\..\felvettTargyak.txt"))
            {
                StreamReader file = new StreamReader("..\\..\\..\\felvettTargyak.txt", Encoding.UTF8);
                while (!file.EndOfStream)
                {
                    string sor = file.ReadLine();
                    string[] szavak = sor.Split(',');//0. elem hallgato Neptun kód, 1. elem tárgy Neptun kód
                    if (szavak[0] == hallgato.Neptun)
                    {
                        int i = 0;
                        while (i < felvehetoTargyak.Count && felvehetoTargyak[i].Neptun != szavak[1])
                            i++;
                        if (i < felvehetoTargyak.Count)
                        {
                            Targy targy = felvehetoTargyak[i];
                            felvettTargyak.Add(targy);
                            lbFelvettTargyak.Items.Add(targy.Nev);
                            //Ha már felvette a tárgyat akkor az lbFelvehetoTargyak közül törölje
                            if (lbFelvehetoTargyak.Items.Contains(targy.Nev)) { 
                                lbFelvehetoTargyak.Items.Remove(targy.Nev);
                                lbFelvehetoTargyak.Refresh();
                            }

                        }
                    }
                }
                file.Close();
            }
            else
                MessageBox.Show("Nem találom a felvettTargyak.txt fájlt!");

        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            if (lbFelvehetoTargyak.SelectedItem != null)
            { Targy t = new Targy("aa","AAA",2);
                lbFelvettTargyak.Items.Add(lbFelvehetoTargyak.SelectedItem);
                felvettTargyak.Add(felvehetoTargyak[lbFelvehetoTargyak.SelectedIndex]);
                t = felvettTargyak[felvettTargyak.Count-1];
                lbFelvehetoTargyak.Items.Remove(lbFelvehetoTargyak.SelectedItem);
               felvehetoTargyak.Remove(t);
            }
        }

        private void TargyFelvetelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter file = new StreamWriter(@"..\..\..\felvettTargyak.txt",true);
            foreach (Targy t in felvettTargyak)
            {
                file.WriteLine(hallgato.Neptun + "," + t.Neptun);
            }
            file.Close();
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            if (lbFelvettTargyak.SelectedItem != null)
            {
                lbFelvehetoTargyak.Items.Add(lbFelvettTargyak.SelectedItem);
                felvettTargyak.Remove(felvettTargyak[lbFelvettTargyak.SelectedIndex]);
                lbFelvettTargyak.Items.Remove(lbFelvettTargyak.SelectedItem);
            }
        }

        private void TargyFelvetelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
