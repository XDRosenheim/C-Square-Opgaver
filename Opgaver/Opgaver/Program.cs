using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Console.Clear();
                Console.WriteLine("Opgave ");

                Console.ReadKey();
             */


            //Opgave 1
            Console.Clear();
            Console.WriteLine("Opgave 1");
            Console.WriteLine("Indtast dit navn: ");
            string opg1_navn = Console.ReadLine();
            Console.WriteLine(opg1_navn);
            Console.ReadKey();

            //Opgave 2
            Console.Clear();
            Console.WriteLine("Opgave 2");
            int opg2_i = 2;
            Console.WriteLine(opg2_i);
            Console.ReadKey();

            //Opgave 3
            Console.Clear();
            Console.WriteLine("Opgave 3");
            int opg3_i = 3;
            Console.WriteLine("Indtast dit navn: ");
            string opg3_navn = Console.ReadLine();
            Console.WriteLine("Output: " + opg3_i + " " + opg3_navn + " !");
            Console.ReadKey();

            //Opgave 5
            Console.Clear();
            Console.WriteLine("Opgave 5 - Sprang 4 over.");
            int opg5_i = 5;
            Console.WriteLine(opg5_i + " Hej med dig");
            Console.ReadKey();

            //Opgave 6
            Console.Clear();
            Console.WriteLine("Opgave 6");
            int opg6_i = new int();
            string opg6_string = "6";
            int.TryParse(opg6_string, out opg6_i);
            Console.WriteLine(opg6_i);
            Console.ReadKey();

            //Opgave 7
            Console.Clear();
            Console.WriteLine("Opgave 7");

            Console.ReadKey();
        }
    }
}
