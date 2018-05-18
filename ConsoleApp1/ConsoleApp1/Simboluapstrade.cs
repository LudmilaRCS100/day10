using System;

using System.Collections.Generic;

using System.Text;



namespace Pd_2

{

    class AdvancedMath

    {

        public void Reizinat()

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

            Console.WriteLine(sk1 * sk2); //izvada skaitlu starpibu

        }



        public void Dalit()

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

            Console.WriteLine(sk1 / sk2); //izvada skaitlu starpibu

        }

    }

}