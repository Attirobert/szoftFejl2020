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
        List<string> huHU = new List<string>()
        {
            "Generál",
            "Páratlan elemek összege",
            "Főátlók összege",
            "Sorokban lévő elemek összege",
            "Oszlopokban lévő elemek összege",
            "Transzponáld",
            "Kilépés",
            "Műveletek"
        };
        public Form1()
        {
            InitializeComponent();
            matrixGeneralasa();
            nyelvBeallitasa(huHU);
        }

        private void nyelvBeallitasa(List<string> nyelv)
        {
            generalToolStripMenuItem.Text = nyelv[0];
            páratlanElemekÖsszegeToolStripMenuItem1.Text = nyelv[1];
            főátlókÖsszegeToolStripMenuItem.Text = nyelv[2];
            sorokbanLévőElemekÖsszegeToolStripMenuItem.Text = nyelv[3];
            oszlopokbanLévőElemekÖsszegeToolStripMenuItem.Text = nyelv[4];
            transzponáldToolStripMenuItem.Text = nyelv[5];
            kilépésToolStripMenuItem.Text = nyelv[6];
            muveletekToolStripMenuItem.Text = nyelv[7];
        }

        private  void DatagridFeltoltes()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount= 3;
            dataGridView1.Columns[0].Width = dataGridView1.Columns[1].Width = dataGridView1.Columns[2].Width = 30;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[3];
                for (int j = 0; j < matrix.GetLength(1); j++) row[j] = matrix[i, j];
                dataGridView1.Rows.Add(row);
            }
        }

        private void matrixGeneralasa()
        {
            int[,] temp = new int[3, 3];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = r.Next(10, 21);
                } 
            }   
            matrix = temp;
            DatagridFeltoltes();
            dispatcher(lbMegnevezes.Text);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dispatcher(((ToolStripMenuItem)sender).Text);
        }

        private void dispatcher(string text)
        {
            if (text == huHU[0]) { matrixGeneralasa(); return; }
            if (text == huHU[1]) { paratlan(text); return; }
            if (text == huHU[2]) { atlokOsszege(text); return; }
            if (text == huHU[3]) { sorokOsszege(text); return; }
            if (text == huHU[4]) { oszlopokOsszege(text); return; }
            if (text == huHU[5]) { transporalas(); return; }
            if (text == huHU[6]) { Close(); }
        }

        private void oszlopokOsszege(string megnevezes)
        {
            lbMegnevezes.Text = megnevezes;
            lbEredmeny.Text = String.Empty;
            int[] Oszlopok = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Oszlopok[j] += matrix[i, j];
                }
            }
            for (int i = 0; i < Oszlopok.Length; i++)
            {
                lbEredmeny.Text += $"{i + 1}: {Oszlopok[i]}\n";
            }
        }

        private void sorokOsszege(string megnevezes)
        {
            lbMegnevezes.Text = megnevezes;
            lbEredmeny.Text = String.Empty;
            int[] Sorok = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Sorok[i] += matrix[i, j];
                }
            }
            for (int i = 0; i < Sorok.Length; i++)
            {
                lbEredmeny.Text += $"{i + 1}: {Sorok[i]}\n";
            }
        }

        private void atlokOsszege(string megnevezes)
        {
            lbMegnevezes.Text = megnevezes;
            int atloEgy=0, atloKetto=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j <= i; j++)
                {
                    atloEgy += matrix[i, j];
                    atloKetto += matrix[i, matrix.GetLength(0) - i-1];
                }
            }
            lbEredmeny.Text = $"{atloEgy + atloKetto}";
        }

        private void paratlan(string megnevezes)
        {
            lbMegnevezes.Text = megnevezes;
            int eredmeny = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j =0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2!=0)
                    {
                        eredmeny += matrix[i, j];
                    }
                }
            }
            lbEredmeny.Text = eredmeny.ToString();
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
                matrix[0, j] = oszlop1[oszlop1.Count - (j) - 1];
                matrix[1, j] = oszlop2[oszlop2.Count - (j) - 1];
                matrix[2, j] = oszlop3[oszlop3.Count - (j) - 1];
            }
            DatagridFeltoltes();
            dispatcher(lbMegnevezes.Text);
        }
    }
}
