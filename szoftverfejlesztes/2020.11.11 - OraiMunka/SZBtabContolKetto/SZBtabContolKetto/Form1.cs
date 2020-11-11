using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SZBtabContolKetto
{
    public partial class Form1 : Form
    {
        int p1 = 0;
        public Form1()
        {
            InitializeComponent();
            p1 = lowestTabIndexFromGroupBox();
            
        }

        private void setFocus(int index)
        {
            ((TextBox)groupBox1.Controls[index]).Focus();
        }

        private int lowestTabIndexFromGroupBox()
        {
            int min = ((TextBox)groupBox1.Controls[0]).TabIndex;
            int index = 0;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (((TextBox)groupBox1.Controls[i]).TabIndex < min){
                    min = ((TextBox)groupBox1.Controls[i]).TabIndex;
                    index = i;
                }
                ;
            }

            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = String.Empty;
            tabControl1.SelectedIndex = 1;
            List<int> szamok = GroupBoxContentToList();
            if (szamok.Count == 2) eredmenyKiir(mertaniKozepKiszamolasa(szamok));
            else {tabControl1.SelectedIndex = 0; mezokKinullazasa();}
        }

        private void eredmenyKiir(int erdemeny) { label3.Text = erdemeny.ToString(); }
         
        private void mezokKinullazasa() { for (int i = 0; i < groupBox1.Controls.Count; i++) ((TextBox)groupBox1.Controls[i]).Text = String.Empty; }

        private int mertaniKozepKiszamolasa(List<int> szamok) { return ((szamok[0] + szamok[1]) / szamok.Count); }

        private List<int> GroupBoxContentToList()
        {
            List<int> temp = new List<int>();
            int szam;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (int.TryParse(((TextBox)groupBox1.Controls[i]).Text,out szam)) temp.Add(szam);
                else MessageBox.Show("Hibás beviteli adat(ok)", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return temp;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Kilépsz?", "Bezar Ablak", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) e.Cancel = true;
            else tabControl1.SelectedIndex = 0;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            //textBox1.Focus();
            setFocus(p1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
