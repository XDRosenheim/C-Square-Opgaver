using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alder = new int();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Alder: ");
                string s_Alder = Console.ReadLine();
                bool Converted = int.TryParse(s_Alder, out Alder);
                if (Converted == true)
                {
                    Console.Write("Fornavn: ");
                    string Fornavn = Console.ReadLine();
                    Console.WriteLine("Din alder er " + Alder + " og dit efternavn er " + Fornavn);
                    break;
                }
                else
                {
                    Console.WriteLine("Kun tal.");
                }
            }

            Console.ReadKey();
        }
    }
}