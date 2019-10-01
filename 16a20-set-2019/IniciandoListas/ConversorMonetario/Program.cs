using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonetario
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor:");
            var meuValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo para converter:");
            Console.WriteLine("EURO - DOLAR - YEN - BTC");

            var meuAlvo = Console.ReadLine();

            MetodosPublicos.Program.ConvertMoeda(meuValor, meuAlvo);

           
            
            Console.ReadKey();
        }

        
    }
}
