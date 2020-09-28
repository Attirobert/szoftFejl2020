using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnTotalTop_MouseClick(object sender, MouseEventArgs e)
        {
            lathatosagok();
            Top = 0;
            BtnTotalTop.Hide();
            BtnTop.Hide();


        }

        private void btnTotalRight_MouseClick(object sender, MouseEventArgs e)
        {
            lathatosagok();
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            //SetVisibleCore(true);
            btnTotalRight.Hide();
            BtnRight.Hide();
            

        }

        private void BtnTotalBottom_MouseClick(object sender, MouseEventArgs e)
        {
            lathatosagok();
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            BtnTotalBottom.Hide();
            BtnBottom.Hide();
            
        }

        private void BtnTotalLeft_MouseClick(object sender, MouseEventArgs e)
        {
            lathatosagok();
            Left = 0;
            BtnTotalLeft.Hide();
            BtnLeft.Hide();

        }

        private void lathatosagok()
        {
            BtnTotalLeft.Visible = true;
            BtnLeft.Visible = true;

            BtnTotalBottom.Visible = true;
            BtnBottom.Visible = true;

            btnTotalRight.Visible = true;
            BtnRight.Visible = true;

            BtnTotalTop.Visible = true;
            BtnTop.Visible = true;

            BtnMiddle.Visible = true;
        }

        private void BtnLeft_MouseClick(object sender, MouseEventArgs e)
        {
            Left -=10;
            lathatosagok();
        }

        private void BtnRight_MouseClick(object sender, MouseEventArgs e)
        {
            Left += 10;
            lathatosagok();
        }

        private void BtnTop_MouseClick(object sender, MouseEventArgs e)
        {
            Top -= 10;
            lathatosagok();
            if (Top > Screen.PrimaryScreen.Bounds.Height - (Height - 1))
            {
                BtnTotalBottom.Hide();
                BtnBottom.Hide();
            }
        }

        private void BtnBottom_MouseClick(object sender, MouseEventArgs e)
        {
            Top += 10;
            lathatosagok();
            if (Top > Screen.PrimaryScreen.Bounds.Height - (Height-1))
            {
                BtnTotalBottom.Hide();
                BtnBottom.Hide();
            }
        }

        private void BtnMiddle_MouseClick(object sender, MouseEventArgs e)
        {
            lathatosagok();
            Top = (Screen.PrimaryScreen.Bounds.Height -Height)/2;
            Left = (Screen.PrimaryScreen.Bounds.Width -Width)/2;
            BtnMiddle.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Width += 10;
            Height += 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Width -= 10;
            Height -= 10;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
