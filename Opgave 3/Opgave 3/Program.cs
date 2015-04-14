using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Output: " + i + " " + navn + " !");
        }
    }
}
