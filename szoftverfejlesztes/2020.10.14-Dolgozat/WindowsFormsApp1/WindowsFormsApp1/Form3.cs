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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int[,] matrix)
        {
            InitializeComponent();
            List<string> l = new List<string>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    l.Add(matrix[i, j].ToString());
                }
            }
            lbMatrix2.DataSource = l;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
