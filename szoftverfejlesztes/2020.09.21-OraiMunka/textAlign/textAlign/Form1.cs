using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textAlign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbszoveg_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (lbszoveg.Width / 3);
            int m = e.Y / (lbszoveg.Height / 3);

            switch (m*3+n)
            {
                case 0:
                    lbszoveg.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    lbszoveg.TextAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    lbszoveg.TextAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    lbszoveg.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    lbszoveg.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    lbszoveg.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    lbszoveg.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    lbszoveg.TextAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    lbszoveg.TextAlign = ContentAlignment.BottomRight;
                    break;
                default:
                    break;
            }
        }

        private void lbszoveg_MouseMove(object sender, MouseEventArgs e)
        {
            int n = e.X / (lbszoveg.Width / 3);
            int m = e.Y / (lbszoveg.Height / 3);

            switch (m * 3 + n)
            {
                case 0:
                    lbszoveg.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    lbszoveg.TextAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    lbszoveg.TextAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    lbszoveg.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    lbszoveg.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    lbszoveg.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    lbszoveg.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    lbszoveg.TextAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    lbszoveg.TextAlign = ContentAlignment.BottomRight;
                    break;
                default:
                    break;
            }
        }
    }
}
