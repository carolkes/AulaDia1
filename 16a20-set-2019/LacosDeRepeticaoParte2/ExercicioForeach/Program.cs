using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitLista();
        }

        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>

        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe o seu nome:");

            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }

            Console.ReadKey();
        }

        private static  void    ForeachComSplitLista()
        {
            var conteudo = "nome:Caroline,idade:23 anos;nome:Marcus,idade:31 anos;nome:Madu,idade:6 anos";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"{nome} está com {idade} anos de idade.");
                }
            }

            Console.ReadKey();
 
        }

    }
}
