using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarListas
    {
       public static void ListagemCervejas()
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
        public static void ListagemMarcasCarros()
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
