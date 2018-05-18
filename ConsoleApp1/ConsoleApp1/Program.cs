/*using System;
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


    
}*/
using System;



namespace Pd_2

{

    class Program

    {

        static void Main(string[] args)

        {

            int choice = -1;

            AdvancedMath adv = new AdvancedMath();





            while (choice != 0)

            {

                Console.WriteLine("1- saskaitit");

                Console.WriteLine("2- atnemt");

                Console.WriteLine("3- reizinat");

                Console.WriteLine("4- dalit");



                Console.WriteLine("0- Iziet");



                string izvele = Console.ReadLine();

                choice = Convert.ToInt16(izvele);



                switch (choice)

                {

                    case 1:

                        Saskaitit();

                        break;

                    case 2:

                        Atnemt();

                        break;

                    case 3:

                        adv.Reizinat();

                        break;

                    case 4:

                        adv.Dalit();

                        break;

                    case 0:

                        choice = 0;

                        break;

                    default:

                        Console.WriteLine("Izveleties to, ko piedava!");

                        break;

                }







            }

        }



        /*Funkcija ar parametriem sk1, sk2, kuriem izsaucot funkciju mes dosim vertibu

         * */

        static void Saskaitit()

        {

            double sk1, sk2;

            string virkne1, virkne2;



            Console.WriteLine("Ievadiet skaitli 1");

            virkne1 = Console.ReadLine();

            sk1 = Convert.ToInt16(virkne1);



            Console.WriteLine("Ievadiet skaitli 2");

            virkne2 = Console.ReadLine();

            sk2 = Convert.ToInt16(virkne2);



            Console.Write("Rezultats = ");

            Console.WriteLine(sk1 + sk2);//izvada skaitlu summu

        }



        /*Funkcija ar parametriem sk1, sk2, kuriem izsaucot funkciju mes dosim vertibu

        * */

        static void Atnemt()

        {

            double sk1, sk2;

            string virkne1, virkne2;



            Console.WriteLine("Ievadiet skaitli 1");

            virkne1 = Console.ReadLine();

            sk1 = Convert.ToDouble(virkne1);



            Console.WriteLine("Ievadiet skaitli 2");

            virkne2 = Console.ReadLine();

            sk2 = Convert.ToDouble(virkne2);

            Console.Write("Rezultats = ");

            Console.WriteLine(sk1 - sk2); //izvada skaitlu starpibu

        }

    }

}
