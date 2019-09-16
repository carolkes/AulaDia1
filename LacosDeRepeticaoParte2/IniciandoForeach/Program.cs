using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();
        }
        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre um array de caracteres, ou seja, um texto/palavra
        /// </summary>
        private static  void    IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto:");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;

                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static  void    ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Caroline para realizar busca";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }

            Console.ReadKey();  

        }



    }
}
