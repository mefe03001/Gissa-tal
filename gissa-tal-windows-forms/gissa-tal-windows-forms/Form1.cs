using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gissa_tal_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gissningar = 0;
        static Random slump = new Random();
        int slumptal = ((+slump.Next(100)) + (1));
        private void kontrollera_Click(object sender, EventArgs e)
        {
            int Gissning = int.Parse(gissning.Text);
            gissningar++;
            if (Gissning == slumptal)
            {
                svar.Text = "Du gissade: Rätt!";
                gissningarResultat.Text = ("Du klarade det på: Försök " + gissningar + ".");
            }
            else if (Gissning > slumptal)
            {
                svar.Text = "Du gissade: Fel, talet är mindre";
            }
            else if (Gissning < slumptal)
            {
                svar.Text = "Du gissade: Fel, talet är större";
            }
        }
    }
}
