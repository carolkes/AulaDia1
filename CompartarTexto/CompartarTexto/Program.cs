using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompartarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Era uma vez Caroline que gostava muito de cantar e amassar seus cachorros. Os cachorros da Caroline se chamavam madu, ollie e peca. Caroline cantava pros pássaros, enquanto lavava a louça e enquanto abraçava seus cachorros. Caroline era feliz.";

            primeiroTexto = primeiroTexto.Replace("Caroline", "C").Replace("cachorros", "T");



            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");

         
            Console.ReadKey();


        }
    }
}
