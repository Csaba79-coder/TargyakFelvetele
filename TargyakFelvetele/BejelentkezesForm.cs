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
    public partial class BejelentkezesForm : Form
    {  
        public List<Hallgato> hallgatok = new List<Hallgato>();
        public BejelentkezesForm()
        {
             InitializeComponent();
            StreamReader reader = new StreamReader(@"..\..\..\hallgatok.txt");
            while (!reader.EndOfStream)
            {
                Hallgato hallgato = new Hallgato(reader.ReadLine(), reader.ReadLine(), reader.ReadLine());
                hallgatok.Add(hallgato);
            }
            reader.Close();
        }
        Hallgato aktHallgato;
        internal Hallgato AktHallgato
        {
            get { return aktHallgato; }
            set { aktHallgato = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i= 0;
            while (i < hallgatok.Count && tbNeptun.Text != hallgatok[i].Neptun) { i++; }
            if (i < hallgatok.Count)
            {
                if (tbJelszo.Text == hallgatok[i].Jelszo)
                {
                    //i. hallgató beléphet
                    aktHallgato = hallgatok[i]; 
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Helytelen jelszó");
                    DialogResult = DialogResult.Cancel;
                }
            } else
            {
                MessageBox.Show("Helytelen Neptun kód");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HallgatoFelvitelForm form = new HallgatoFelvitelForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                hallgatok.Clear();
                StreamReader reader = new StreamReader(@"..\..\..\hallgatok.txt");
                while (!reader.EndOfStream)
                {
                    Hallgato hallgato = new Hallgato(reader.ReadLine(), reader.ReadLine(), reader.ReadLine());
                    hallgatok.Add(hallgato);
                }
                reader.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HallgatoTorleseForm form = new HallgatoTorleseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                hallgatok.Clear();
                StreamReader reader = new StreamReader(@"..\..\..\hallgatok.txt");
                while (!reader.EndOfStream)
                {
                    Hallgato hallgato = new Hallgato(reader.ReadLine(), reader.ReadLine(), reader.ReadLine());
                    hallgatok.Add(hallgato);
                }
                reader.Close();
            }
        }
    }
}
