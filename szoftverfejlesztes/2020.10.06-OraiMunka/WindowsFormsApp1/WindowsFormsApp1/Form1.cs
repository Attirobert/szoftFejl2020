using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Ellenorzes();
        }

        private void Ellenorzes()
        {
            int a, b;

            //Input ellenorzott beolvasása
            if (!int.TryParse(tbxA.Text, out a))
            {
                MessageBox.Show("Nem számot adott meg!" );
                tbxA.Text = String.Empty;
                tbxA.Focus();
                return;
            }

            if (!int.TryParse(tbxB.Text, out b))
            {
                MessageBox.Show("Nem számot adott meg!");
                tbxB.Text = String.Empty;
                tbxB.Focus();
                return;
            }

            if (rbLNKO.Checked)
            {
                MessageBox.Show($"A két szám legnagyobb közös osztója: {lnko(a, b)}");
            }

            if (rbLKKO.Checked)
            {
                MessageBox.Show($"A két szám legkissebb közös többszöröse: {(a * b) / lnko(a, b)}");
            }
        }


        private int lnko(int a, int b)
        {
            //% modulo
            //
            if (a == 0) return b;
            if (b == 0) return a;
            if (a > b) return lnko(a % b, b);
            else return lnko(a, b % a);
        }
    }
}
