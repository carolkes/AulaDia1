using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira aqui o texto:");
            var textoLenght = Console.ReadLine();

            Console.WriteLine($"O número de caracteres deste texto é: {textoLenght.Replace(" ", "").Length}");

            Console.ReadKey();
        }
        

    }

}
