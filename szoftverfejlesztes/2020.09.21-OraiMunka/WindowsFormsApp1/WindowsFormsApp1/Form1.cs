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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBalraFel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnJobbraFel_Click(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void btnBalLe_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnJobbraLe_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Left= Screen.PrimaryScreen.Bounds.Width - Width;
        }
    }
}
