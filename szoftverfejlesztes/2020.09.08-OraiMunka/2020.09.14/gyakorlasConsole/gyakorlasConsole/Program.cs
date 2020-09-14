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
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
