using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCrazy
{
    class Program
    {
        public static void Main(string[] args)
        {
            

        }

        private static  void    DesenhoArvore()
        {
            Console.WriteLine("            $$$$$$$$$$             ");
            Console.WriteLine("          $$$$$$$$$$$$$$           ");
            Console.WriteLine("         $$$$$$$$$$$$$$$$$                     ");
            Console.WriteLine("        $$$$$$$$$$$$$$$$$$$                      ");
            Console.WriteLine("       $$$$$$$$$$$$$$$$$$$$$               ");
            Console.WriteLine("      $$$$$$$$$$$$$$$$$$$$$$$                              ");
            Console.WriteLine("       $$$$$$$$$$$$$$$$$$$$$                ");
            Console.WriteLine("        $$$$$$$$$$$$$$$$$$$               ");
            Console.WriteLine("         $$$$$$$$$$$$$$$$$              ");
            Console.WriteLine("          $$$$$$$$$$$$$$             ");
            Console.WriteLine("             ||||||||          ");
            Console.WriteLine("             ||||||||          ");
            Console.WriteLine("             ||||||||         ");
            Console.WriteLine("             ||||||||        ");
            Console.WriteLine("             ||||||||        ");
            Console.WriteLine("             ||||||||     *  ");
            Console.WriteLine("             ||||||||     |   ");
            Console.WriteLine("      MMMMMMMMMMMMMMMMMMMMMMMMM   ");

            Console.ReadKey();
        }
        public double CalculoAreaDeUmQuadrado(int ladoqud)
        {
            return ladoqud * ladoqud;
        }
        private static  void    ListagemCervejas()
        {
            var minhaLista = new List<string>();

            Console.WriteLine("Segue lista de algumas cervejas que a Ambev produz:");

            minhaLista.Add("Original");
            minhaLista.Add("Budweiser");
            minhaLista.Add("Corona");
            minhaLista.Add("Brahma");
            minhaLista.Add("Skol");
            minhaLista.Add("Antarctica");
            minhaLista.Add("Bohemia");
            minhaLista.Add("Patagonia");

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
        private static  void    ListagemMarcasCarros()
        {
            var minhaLista = new List<string>();

            Console.WriteLine("Segue lista de algumas marcas de carro:");

            minhaLista.Add("Audi");
            minhaLista.Add("BMW");
            minhaLista.Add("Alfa Romeo");
            minhaLista.Add("Corvette");
            minhaLista.Add("Citroen");
            minhaLista.Add("Hyundai");

            minhaLista.ForEach(item => Console.WriteLine(item));

            Console.ReadKey();
        }
    }
    
}
