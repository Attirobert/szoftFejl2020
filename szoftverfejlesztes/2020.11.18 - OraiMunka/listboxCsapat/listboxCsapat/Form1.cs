using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxCsapat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Csapat tag = new Csapat(1, "Béla", Convert.ToDateTime("2020.11.12"));
            ListViewItem row = new ListViewItem();
            row.SubItems.Add(tag.Nev.ToString());
            listView1.Items.Add(row);
            listView1.Items.Add(row);
        }
    }
}
