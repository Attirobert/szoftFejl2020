using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[3, 3];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            matrixGeneralasa();
            
        }

        private  void DatagridFeltoltes()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount= 3;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 30;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[3];
                for (int j = 0; j < matrix.GetLength(1); j++) row[j] = matrix[i, j].ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void matrixGeneralasa()
        {
            int[,] temp = new int[3, 3];
            for (int i = 0; i < temp.GetLength(0); i++) 
                for (int j = 0; j < temp.GetLength(1); j++) 
                    temp[i, j] = r.Next(10, 21);
            matrix = temp;
            DatagridFeltoltes();

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Generál":
                    matrixGeneralasa();
                    break;
                case "Reset":
                    Reset();
                    break;
                case "Transzponáld":
                    transporalas();
                    break;
                case "Páratlan elemek összege":
                    break;
                case "Főátlók összege":
                    break;
                case "Sorokban lévő elemek összege":
                    break;
                case "Oszlopokban lévő elemek összege":
                    break;
            }
        }

        private void transporalas()
        {
            List<int> oszlop1 = new List<int>();
            List<int> oszlop2 = new List<int>();
            List<int> oszlop3 = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                oszlop1.Add(matrix[i, 0]);
                oszlop2.Add(matrix[i, 1]);
                oszlop3.Add(matrix[i, 2]);
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[0, j] = oszlop1[oszlop1.Count - (j)-1];
                matrix[1, j] = oszlop2[oszlop2.Count - (j) - 1];
                matrix[2, j] = oszlop3[oszlop3.Count - (j) - 1];
                ;
            }
            DatagridFeltoltes();
        }

        private void Reset()
        {
            matrix = new int[3, 3];
            DatagridFeltoltes();
            
        }
    }
}
