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
    public partial class HallgatoTorleseForm : Form
    {
        List<Hallgato> hallgatok = new BejelentkezesForm().hallgatok;
        public HallgatoTorleseForm()
        {
            InitializeComponent();
        }

        private void buttonDeleteByNeptun_Click(object sender, EventArgs e)
        {
            string neptun = "";
            for (int i = 0; i < hallgatok.Count; i++)
            {
                if (hallgatok[i].Neptun == textBoxNeptun.Text)
                {
                    neptun = hallgatok[i].Neptun;
                    hallgatok.Remove(hallgatok[i]);
                    break;
                }
            }
            if (neptun == textBoxNeptun.Text)
            {
                MessageBox.Show("Hallgató " + neptun + " neptun kóddal törölve!");
            } else
            {
                MessageBox.Show("Neptun kód: " + textBoxNeptun.Text + " nem létezik a rendszerben!");
            }
            
            StreamWriter writer = new StreamWriter(@"..\..\..\hallgatok.txt", false);
            foreach(Hallgato item in hallgatok)
            {
                writer.WriteLine(item.Nev);
                writer.WriteLine(item.Neptun);
                writer.WriteLine(item.Jelszo);
            }
            writer.Close();
        }

        private void buttonListHallgatok_Click(object sender, EventArgs e)
        {
            foreach(Hallgato item in hallgatok)
            {
                listBox1.Items.Add(item.Neptun + " -> " + item.Nev);
            }
        }

        private void buttonDeleteFromList_Click(object sender, EventArgs e)
        {
            HallgatoTorleseForm form = new HallgatoTorleseForm();
            if (listBox1.SelectedItem != null)
            {
                hallgatok.RemoveAt(listBox1.SelectedIndex);
            }
            StreamWriter writer = new StreamWriter(@"..\..\..\hallgatok.txt", false);
            foreach (Hallgato item in hallgatok)
            {
                writer.WriteLine(item.Nev);
                writer.WriteLine(item.Neptun);
                writer.WriteLine(item.Jelszo);
            }
            writer.Close();
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
