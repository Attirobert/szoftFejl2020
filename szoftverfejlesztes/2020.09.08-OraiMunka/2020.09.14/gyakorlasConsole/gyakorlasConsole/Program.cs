using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gyakorlasConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            //döntsük el egy számról hogy természetes szám-e. A nullával kezdődő szám nem természetes
            string minta = "^[1-9][0-9]*$";
            Regex pattern = new Regex(minta);
            string s1 = "0567", s2 = "1223344", s3 = "9w65";

            Console.WriteLine($"{s1} : "+((pattern.IsMatch(s1) == true) ? "természetes" : "nem természetes").ToString());
            Console.WriteLine($"{s2}: " + ((pattern.IsMatch(s1) == true) ? "természetes" : "nem természetes").ToString());
            Console.WriteLine($"{s3}: " + ((pattern.IsMatch(s1) == true) ? "természetes" : "nem természetes").ToString());
            Console.WriteLine();
            //----------------------------------------------------------------------
            //irányítószám nem kezdődhet nullával

            string minta2 = "^[1-9][0-9]{3}$";
            pattern = new Regex(minta2);
            string z1 = "4100", z2 = "0100", z3 = "0w00";

            Console.WriteLine($"{z1}: " + ((pattern.IsMatch(z1)==true)?"helyes":"helytelen").ToString());
            Console.WriteLine($"{z2}: "+ ((pattern.IsMatch(z2) == true) ? "helyes" : "helytelen").ToString());
            Console.WriteLine($"{z3}: " + ((pattern.IsMatch(z3) == true) ? "helyes" : "helytelen").ToString());
            Console.WriteLine();*/

            double[,] temperatur = new double[12,30];
            Random r = new Random();
            string honap = "";
            double min = 0, max=0;

            for (int i = 0; i < temperatur.GetLength(0); i++)
            {
                honap = String.Empty;
                for (int e = 0; e < temperatur.GetLength(1); e++)
                {
                    temperatur[i, e] = (double)r.Next(-1000, 3501) / 100;
                    honap += temperatur[i, e] + " ";
                    if(temperatur[i, e] < min)min = temperatur[i, e];
                    if (temperatur[i, e] > max)max = temperatur[i, e];
                }
                Console.WriteLine($"{((honapok)i).ToString()}: {honap}\n" );
            }

            Console.WriteLine($"Min éves hőmérséklet: {min}");
            Console.WriteLine($"Max éves hőmérséklet: {max}");
            Console.ReadKey();
        }
        enum honapok
        {
            jan, febr, márc, ápr, máj, jún, júl, aug, szep, okt, nov, dec
        }
    }
}
