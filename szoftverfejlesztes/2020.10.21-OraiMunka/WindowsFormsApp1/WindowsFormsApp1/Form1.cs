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

            comboBox1.SelectedIndex = 0;
            maskedTextBox1.Text = dateTimePicker4.Value.ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            label1.Text = $"{Convert.ToInt32((date2 - date1).ToString("dd"))}";
            label1.Text = String.Format("Enyi: {0}", (dateTimePicker2.Value - dateTimePicker1.Value).Days);
        }

        //kettő
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = monthCalendar1.SelectionStart.Date;
            DateTime date2 = monthCalendar2.SelectionStart.Date;
            label2.Text = $"{Convert.ToInt32((date2 - date1).ToString("dd"))}";
        }

        //harom
        private void label6_Click(object sender, EventArgs e)
        {
            //csillagjegyek
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker3.Value.ToString("MM.dd.");
            int datumom = Array.ConvertAll(date1.ToCharArray(), c => Convert.ToInt32(c)).Sum();
            string eredmeny="";
            bool b = false;
            ;

            b= Horoszkop(datumom,"03.21.", "04.20.", "Kos");
            if (b) { eredmeny = "kos"; };

            b = Horoszkop(datumom, "04.21.", "05.20.", "Bika");
            if (b) { eredmeny = "Bika"; };

            b = Horoszkop(datumom, "05.21.", "06.21.", "Ikrek ");
            if (b) { eredmeny = "Ikrek"; };

            label6.Text = eredmeny;
        }

        private bool Horoszkop(int datum, string kezdete, string vege, string horoszkop)
        {
            if (datum >= Array.ConvertAll(kezdete.ToCharArray(), c => Convert.ToInt32(c)).Sum()
                && datum <= Array.ConvertAll(vege.ToCharArray(), c => Convert.ToInt32(c)).Sum())
            { return true; }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: dateTimePicker4.Value=dateTimePicker4.Value.AddYears(Convert.ToInt32(numericUpDown1.Value)); break;
                case 1: dateTimePicker4.Value = dateTimePicker4.Value.AddMonths(Convert.ToInt32(numericUpDown1.Value)); break;
                case 2: dateTimePicker4.Value = dateTimePicker4.Value.AddDays(Convert.ToInt32(numericUpDown1.Value)); break;
                case 3: dateTimePicker4.Value = dateTimePicker4.Value.AddHours(Convert.ToInt32(numericUpDown1.Value)); break;
                case 4: dateTimePicker4.Value = dateTimePicker4.Value.AddMinutes(Convert.ToInt32(numericUpDown1.Value)); break;
            }
            maskedTextBox1.Text = dateTimePicker4.Value.ToString("HH:mm");
        }
    }
}
