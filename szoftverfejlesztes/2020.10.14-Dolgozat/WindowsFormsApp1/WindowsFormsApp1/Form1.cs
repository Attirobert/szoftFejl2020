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
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (!(int.TryParse(txbInput.Text,out n) && n>5 && n<15)) MessageBox.Show("Nem megfelelő bemenet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Generáljon két n x n elemű mátrixot, amelynek elemei véletlen értékű egész számok(legyen benne negatív szám is !).
                int[,] matrix1 = matrixFeltolt(n, n);
                int[,] matrix2 = matrixFeltolt(n, n);

                //Jelenítse meg egy-egy ablakban a két mátrixot.
                Form3 f3 = new Form3(matrix2);
                f3.Show();
                Form f2 = new Form2(matrix1);
                f2.Show();

                //Számolja ki  
                //a.) a két mátrix skaláris szorzatát.
                lbSkalarisSzorzat.Text = skalarrisSzorzat(matrix1, matrix2).ToString();
                //b.) a két mátrix fordított skaláris szorzatát.
                lbForditottSkalarisSzorzat.Text = ForditottSkalarisSzorzat(matrix1, matrix2).ToString();
                //c.) a két mátrix átlóösszegét és vonja ki egymásból.
                lbAtloOsszeg.Text = (atkloOsszeg(matrix1)-atkloOsszeg(matrix2)).ToString();
                //d.) az első mátrix két átlója feletti terület számainak összegét.
                lbUtoklsoFeladat.Text = utso(matrix1).ToString();

                /*Az eredményeket írja ki és formázza az alábbi módon:
                - ha az eredmény nagyobb mint 0, akkor a  karakter színe kék;
                - egyébként piros. */
                lbSkalarisSzorzat.ForeColor =(lbSkalarisSzorzat.Text[0] == '-')? Color.Red: Color.Blue;
                lbForditottSkalarisSzorzat.ForeColor = (lbForditottSkalarisSzorzat.Text[0] == '-') ? Color.Red : Color.Blue;
                lbAtloOsszeg.ForeColor = (lbAtloOsszeg.Text[0] == '-') ? Color.Red : Color.Blue;
                lbUtoklsoFeladat.ForeColor = (lbUtoklsoFeladat.Text[0] == '-') ? Color.Red : Color.Blue;
            }
        }

        private int utso(int[,] matrix1)
        {
            int szam = 0;
            int szamlalo = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                szamlalo = 0;
                for (int j = i+1; j < (matrix1.GetLength(1)-i)-1; j++)
                {
                    szam += matrix1[i, j];
                    szamlalo++;
                }
                if (szamlalo>0 && szamlalo<3)
                {
                    return szam;
                }
            }
            return szam;
        }

        private int atkloOsszeg(int[,] matrix)
        {
            int szam = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j==i)
                    {
                        szam += matrix[i, j];
                        szam += matrix[i, matrix.GetLength(1)-i-1];
                    }
                }
            }
            return szam;
        }

        private int ForditottSkalarisSzorzat(int[,] matrix1, int[,] matrix2)
        {
            int szam =0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    szam += (matrix1[i, j] * matrix2[(matrix2.GetLength(0)-1)-i, (matrix2.GetLength(1) - 1) - i]);
                }
            }
            return szam;
        }

        private int skalarrisSzorzat(int[,] matrix1, int[,] matrix2)
        {
            int szam = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    szam+=(matrix1[i, j] * matrix2[i, j]);
                }
            }
            return szam;
        }

        private int[,] matrixFeltolt(int n1, int n2)
        {
            int[,] tempMatrix = new int[n1, n2];
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    tempMatrix[i, j] = r.Next(-20, 21);
                }
            }
            return tempMatrix;
        }
    }
}
