using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamolgatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.ContextMenuStrip = contextMenuStrip1;
        }

        

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] szamok = {
                    int.Parse(numericUpDown1.Value.ToString()),
                    int.Parse(numericUpDown2.Value.ToString()),
                    int.Parse(numericUpDown3.Value.ToString()) };

            if (((ToolStripMenuItem)sender).Text!= "Mezők törlése")
            {
                bool kilepesMertNegativatVagyNullatTalaltam = false;
                for (int i = 0; i < szamok.Length; i++)
                {
                    if (szamok[i] <= 0)
                    {
                        kilepesMertNegativatVagyNullatTalaltam = true;
                        switch (i)
                        {
                            case 0: numericUpDown1.Focus(); label1.Visible = true; break;
                            case 1: numericUpDown2.Focus(); label2.Visible = true; break;
                            case 2: numericUpDown3.Focus(); label3.Visible = true; break;
                        }
                    }
                }
                if (kilepesMertNegativatVagyNullatTalaltam) return;
            }
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Számtani": listBox1.Items.Add($"{Math.Round((szamok[0] + szamok[1] + szamok[2]) /Convert.ToDouble( szamok.Length), 4)}"); break;
                case "Mértani": listBox1.Items.Add($"Mértani: {Math.Round(Math.Pow(szamok[0] * szamok[1] * szamok[2], 1.00 / szamok.Length),4)}"); break;
                case "Harmónikus": listBox1.Items.Add($"Harmónikus: {Math.Round( szamok.Length / ((1.00 / szamok[0]) + (1.00 / szamok[1]) + (1.00 / szamok[2])),4)}"); break;
                case "Átlag": listBox1.Items.Add($"Átlag: {Math.Round( Convert.ToDouble(szamok[0] * szamok[1] * szamok[2]) / szamok.Length,4)}"); break;
                case "Legnagyobb elem": listBox1.Items.Add($"Legnagyobb elem: {szamok.Max()}"); break;
                case "Mezők törlése": for (int i = 0; i < groupBox1.Controls.Count; i++) ((NumericUpDown)groupBox1.Controls[i]).Value = 1; ; break;
                case "Kilépés": this.Close(); break;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++) ((Label)groupBox2.Controls[i]).Visible = false;
        }
    }
}
