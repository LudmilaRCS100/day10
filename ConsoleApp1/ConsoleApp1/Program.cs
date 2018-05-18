using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 1;
            while (n++ < 6)
            {
                Console.WriteLine("Current value of n is {0}", n);
            }

            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            switch (caseSwitch)
            {
                // The following switch section causes an error.  
                case 1:
                    Console.WriteLine("Case 1...");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("... and/or Case 2");
                    break;
                case 4:
                    while (true)
                        Console.WriteLine("Endless looping. . . .");
                default:
                    Console.WriteLine("Default value...");
                    break;
            }


            //Funkcija();//

            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            int results = skaitlis1 + skaitlis2;
            Console.WriteLine("Sanaca " + results + ".");
            Console.ReadLine();


        }
        static void Funkcija()
        {
            int a,b,c,d;

            a = 2;
            b = 3;
            c = 5;


            d = a + b + c;

            Console.WriteLine(d);
                      
            Console.ReadLine();


        }
       









}


    
}
