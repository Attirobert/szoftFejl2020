using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopGyak
{
    class Program
    {
        class Kutya
        {
            //tulajdonságok (properties)
            protected string nev { get; set; }
            protected string fajta { get; set; }
            protected int kor { get; set; }

            public Kutya(string nev) { this.nev = nev; }

            public Kutya(string nev, string fajta)
            {
                this.nev = nev;
                this.fajta = fajta;
            }
            public void ugat(int ugatasSzama) {
                for (int i = 0; i < ugatasSzama; i++) Console.WriteLine("Wau");
            }

            public void bemut()
            {
                Console.WriteLine("Szia a nevem {0}, a fajtám {1}",this.nev, this.fajta);
            }
        }

        class Puli : Kutya
        {
            public Puli(string name): base(name){ }

            public void ugat(int p){
                base.ugat(p);
                Console.WriteLine("Én a {0} vagyok",this.nev);}
        }
        static void Main(string[] args)
        {
            Kutya bodri = new Kutya("Bodri");
            bodri.ugat(3);
            Console.WriteLine();

            Puli p = new Puli("Puli");
            p.ugat(12);
            


            Kutya bogancs = new Kutya("bogancs","komondor");
            bogancs.bemut();
            Console.ReadKey();
        }
    }
}
