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
        public class UtazasiCel
        {
            public string megnevezes;
            public int ar;

            public UtazasiCel(string megnevezes, int ar)
            {
                this.megnevezes = megnevezes;
                this.ar = ar;
            }
        }

        public class Kedvezmenyek
        {
            public string megnevezes;
            public int ar;

            public Kedvezmenyek(string megnevezes, int ar)
            {
                this.megnevezes = megnevezes;
                this.ar = ar;
            }
        }

        public class Szolgaltatasok
        {
            public string megnevezes;
            public int ar;

            public Szolgaltatasok(string megnevezes, int ar)
            {
                this.megnevezes = megnevezes;
                this.ar = ar;
            }
        }
    }
}
