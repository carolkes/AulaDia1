using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
         static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop",
            };

        static void Main(string[] args)
        {
  
            AdicionarItensALista();

            ListaInformacoes();

            Console.ReadKey();
        }

        private static  void    AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja Informar mais valores? sim(S) não(N)");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
            AdicionarItensALista();
        }
        /// <summary>
        /// Método que mostra  a lista
        /// </summary>
        private static  void    ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome:{item} foi adicionado a lista");
        }
        
    }
}
