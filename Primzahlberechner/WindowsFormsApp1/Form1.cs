using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zahl;
            string wort;
            zahl = Convert.ToInt32(textBox1.Text);
            if (berechner(zahl)==false)
            {
                wort = "keine";
            }
            else
            {
                wort = "eine";
            }
            
            label1.Text = Convert.ToString(zahl) + " ist " + wort + " Primzahl";

        }
        bool berechner(int zahl)
        {
            int counter = 0;
            int teiler = 0;

            for (teiler = zahl; teiler > 0; teiler--)
            {
                if (zahl % teiler == 0)
                {
                    counter++;
                }

            }

            if (counter == 2)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
