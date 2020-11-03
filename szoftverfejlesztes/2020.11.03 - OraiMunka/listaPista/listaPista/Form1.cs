using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaPista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Generálás":
                    Random r = new Random();
                    for (int i = 0; i < 10; i++) listBox1.Items.Add(r.Next(10, 21));
                    break;
                case "Elem hozzáadása":
                    textBox1.Visible = true;
                    button1.Visible = true;
                    break;
                case "Elem törlése":
                    if (listBox1.SelectedIndex!=-1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    break;
                case "Reset":
                    listBox1.Items.Clear();
                    break;
                case "Kilépés":
                    Close();
                    break;
            }
            statusFrissitese();
        }

        private void statusFrissitese()
        {
            List<int> egy = new List<int>();
            for (int i = 0; i < listBox1.Items.Count; i++) egy.Add(Convert.ToInt32(listBox1.Items[i]));

            toolStripStatusLabel1.Text = (listBox1.Items.Count != 0) ? $"Elemek száma: {egy.Count}" : $"Elemek száma: {0}";
            toolStripStatusLabel2.Text = (listBox1.Items.Count != 0) ? $"Legkissebb elem: {egy.Min()}" : $"Legkissebb elem: {0}";
            toolStripStatusLabel3.Text = (listBox1.Items.Count != 0) ? $"Legnagyobb elem: {egy.Max()}" : $"Legnagyobb elem: {0}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            statusFrissitese();
            textBox1.Text = String.Empty;
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0)
            {
                int number;
                textBox1.Text=(int.TryParse(textBox1.Text, out number))? number.ToString(): textBox1.Text.TrimEnd(textBox1.Text[textBox1.Text.Length - 1]);
            }
        }

    }
}
