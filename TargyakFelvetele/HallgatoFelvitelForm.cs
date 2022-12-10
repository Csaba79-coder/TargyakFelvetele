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
    public partial class HallgatoFelvitelForm : Form
    {
        public HallgatoFelvitelForm()
        {
            InitializeComponent();
        }

        private void buttonFelvitel_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"..\..\..\hallgatok.txt", true);
            writer.WriteLine(textBoxName.Text);
            writer.WriteLine(textBoxNeptun.Text);
            writer.WriteLine(textBoxPassword.Text);
            writer.Close();
        }
    }
}
