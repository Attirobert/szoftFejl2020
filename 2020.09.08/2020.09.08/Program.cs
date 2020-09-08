using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._09._08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool OutOfLoop = false;
            do
            {
                OutOfLoop = false;
                try
                {
                    Console.Write("szám1: ");
                    double szam1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("szám2: ");
                    double szam2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("műveleti jel: ");
                    char op = Convert.ToChar(Console.ReadLine());
                    double eredmeny = 0;
                    string nulla = "";
                    
                    Console.WriteLine(nulla=(szam2==0&&op=='/')?"ne osszál nullával. Nem lehet nullával osztani!\n":"");
                    if (nulla=="")
                    {
                        switch (op)
                        {
                            case '+':
                                eredmeny = szam1 + szam2;
                                break;
                            case '-':
                                eredmeny = szam1 - szam2;
                                break;
                            case '/':
                                eredmeny = szam1 / szam2;
                                break;
                            case '*':
                                eredmeny = szam1 * szam2;
                                break;
                            default:
                                Console.WriteLine("Nem ismerek ilyen operátort!");
                                break;
                        }
                        Console.WriteLine("Eredmény: {0}", eredmeny);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("hibás bevitel");
                }

                Console.WriteLine("Szeretnél Újra számolni? (i/n)");
                char c = Convert.ToChar(Console.ReadLine().ToLower());
                OutOfLoop = (c == 'i') ? true : false;
            } while (OutOfLoop);
        }
        
    }
}
