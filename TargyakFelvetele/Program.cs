using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargyakFelvetele
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BejelentkezesForm bejelentkezes = new BejelentkezesForm();
            if (bejelentkezes.ShowDialog() == DialogResult.OK)
            {Application.Run(new TargyFelvetelForm(bejelentkezes.AktHallgato)); }
        }
    }
}
