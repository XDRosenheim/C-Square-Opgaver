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
            Console.Write("Fornavn: ");
            string fornavn = Console.ReadLine();
            Console.Write("Efternavn: ");
            string efternavn = Console.ReadLine();
            Console.WriteLine("Dit fulde navn: " + fornavn + " " + efternavn);
            Console.ReadKey();
        }
    }
}
