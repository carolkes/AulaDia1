using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (count < 10)
            {
                Console.WriteLine($"Número:{count}");
                count++;
            }

            Console.WriteLine("Terminou o loop");
            Console.ReadKey();

        }
    }
}
