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
        List<UtazasiCel> celList = new List<UtazasiCel>();
        List<Kedvezmenyek> KedvezmenyList = new List<Kedvezmenyek>();
        List<Szolgaltatasok> SzolgaltatasList = new List<Szolgaltatasok>();

        public Form1()
        {
            InitializeComponent();

            //Utazási célok:
            celList.Add(new UtazasiCel("Budapest", 1500));
            celList.Add(new UtazasiCel("Hatvan", 1300));
            celList.Add(new UtazasiCel("Székesfehérvár", 2000));
            celList.Add(new UtazasiCel("Kecskemét", 2800));
            for (int i = 0; i < celList.Count; i++)
            {
                cbxCel.Items.Add(celList[i].megnevezes);
            }

            //Kedvezmények:
            KedvezmenyList.Add(new Kedvezmenyek("-", 0));
            KedvezmenyList.Add(new Kedvezmenyek("nappali tagozatos diák", 50));
            KedvezmenyList.Add(new Kedvezmenyek("nyugdíjas", 50));
            KedvezmenyList.Add(new Kedvezmenyek("törzsutas kártya", 70));
            for (int i = 0; i < KedvezmenyList.Count; i++)
            {
                cbxKedvezmeny.Items.Add(KedvezmenyList[i].megnevezes);
            }

            //Szolgáltatások:
            SzolgaltatasList.Add(new Szolgaltatasok("kutya", 800));
            SzolgaltatasList.Add(new Szolgaltatasok("bicikli", 600));
            SzolgaltatasList.Add(new Szolgaltatasok("túlméretes poggyász", 400));
            for (int i = 0; i < SzolgaltatasList.Count; i++)
            {
                clbSzolgaltatas.Items.Add(SzolgaltatasList[i].megnevezes);
            }

            //kezdőértékek beállítása
            Reset();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int ar =celList[cbxCel.SelectedIndex].ar;
            int kedveznmeny = KedvezmenyList[cbxKedvezmeny.SelectedIndex].ar;
            int szolgaltatas = szolgaltatasOsszeadasa();
            
            lbEredmeny.Text = $"{((ar - ((ar / 100) * kedveznmeny)) + szolgaltatas)} Ft";
        }

        private int szolgaltatasOsszeadasa()
        {
            int szam = 0;
            for (int i = 0; i < clbSzolgaltatas.CheckedItems.Count; i++)
            {
                szam += SzolgaltatasList[clbSzolgaltatas.Items.IndexOf(clbSzolgaltatas.CheckedItems[i])].ar;
            }
            return szam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            //Szolgaltatas
            for (int i = 0; i < clbSzolgaltatas.Items.Count; i++)
            {
                clbSzolgaltatas.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Utazasi Cél
            cbxCel.SelectedIndex = 0;

            //kedvezmeny
            cbxKedvezmeny.SelectedIndex = 0;
        }
    }
}
