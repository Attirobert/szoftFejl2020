using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        Font fontArial = new Font("Arial", 12,FontStyle.Italic);
        Font fontTimes = new Font("Times New Roman", 12, FontStyle.Bold);
        Font fontComic = new Font("Comic Sans", 12,FontStyle.Underline);

        private void Form1_Load(object sender, EventArgs e)
        {
            //kezdeti értékek beállítása
            cbxValaszt.Items.Add("Szoveg");
            cbxValaszt.Items.Add("Hatter");
            cbxValaszt.SelectedIndex = 0;

            nudMeret.Minimum = 8;
            nudMeret.Maximum = 36;
            nudMeret.Increment = 2;

            rtbSzoveg.Text = "proba";
            
            rtbSzoveg.Font = fontArial;
            rtbSzoveg.ForeColor = Color.Red;
            rtbSzoveg.BackColor = Color.Green;
        }

        private void cbxValaszt_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxValaszt.SelectedIndex==0)
            {
                
                dynamic szin = "";
                dynamic betűtopus = "";
                dynamic betűméret = "";
                dynamic stilus = "";

                if (rbKek.Checked) szin = Color.Blue;
                if (rbPiros.Checked) szin = Color.Red;
                if (rbZold.Checked) szin = Color.Green;

                if (rbArial.Checked) betűtopus = "Arial";
                if (rbCs.Checked) betűtopus = "Comic Sans";
                if (rbTnr.Checked) betűtopus = "Timeas New Roman";

                betűméret = Convert.ToInt32(nudMeret.Value);

                if (cbxAlahuzott.Checked) {

                    stilus = FontStyle.Underline;
                    rtbSzoveg.Font= new Font(betűtopus, betűméret, FontStyle.Underline);
                    rtbSzoveg.ForeColor = szin;
                    
                }
                if (cbxDolt.Checked) { 
                    stilus = FontStyle.Italic; 
                    rtbSzoveg.Font= new Font(betűtopus, betűméret, FontStyle.Italic);
                    rtbSzoveg.ForeColor = szin;
                }
                if (cbxFelkover.Checked) { 
                    stilus = FontStyle.Bold; 
                    rtbSzoveg.Font= new Font(betűtopus, betűméret, FontStyle.Bold);
                    rtbSzoveg.ForeColor = szin;
                }

                //az agyam nyitva áll, erdős istván, az igazán nagy dolgok igazan egyszeruek, és szépek
            }
        }
    }
}
