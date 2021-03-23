using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Egy labelnek módosítható a szine a COLOR DIALOG segítségével
        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                label1.BackColor = colorDialog1.Color;
                label2.Text = colorDialog1.Color.ToString();
            }
        }

        //Egy pictureBox-ba betölthetünk képet a FileDialog segitségével
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.JPG";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        //egy ritchTextBoxba betölthető TXT fileok a FileDialog segitségével
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.TXT";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
                richTextBox1.Text = text;
            }
        }

        //kimentjük a richTextBoxból egy fileba annak tartalmát a FileDialog segitségével
        private void button4_Click(object sender, EventArgs e)
        {
            string mentesText = richTextBox1.Text;
            SaveFileDialog sfd = new SaveFileDialog();
            if(DialogResult.OK== sfd.ShowDialog())
            {
                File.WriteAllText(sfd.FileName, mentesText);
                MessageBox.Show("Mentve");
            }
        }
    }
}
