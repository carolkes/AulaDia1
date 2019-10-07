using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomePessoas
{
    class Program
    {
        static List<Pessoa> listaPessoas = new List<Pessoa>();

        static List<string> listaNome = new List<string>()
        {
           "Caroline",
           "Vinícius",
           "Brigitte",
           "Edson",
           "Abner",
           "Jéssica",
           "André",
           "Carolina",
           "Madu",
           "Ollie",
           "Peca",

        };

        static void Main(string[] args)
        {
            MenuSistema();

            Console.ReadKey();
        }
        private static void AdicionarNomesALista()
        {
            listaNome.Sort();
            listaNome.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("Inserir nome na lista:");
            listaNome.Add(Console.ReadLine());
        }
        private static void ListaInformacoesADD()
        {
            Console.WriteLine("Lista com os nomes adicionados");
            listaNome.Sort();
            foreach (var nome in listaNome)
                Console.WriteLine($"{nome}");
        }
        private static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Sistema");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("1 - Cadastrar Pessoa");
            Console.WriteLine("2 - Lista Pessoas Cadastradas");
        }
        private static void MenuSistema()
        {
            ImprimirMenu();

            var resposta = int.Parse(Console.ReadLine());

            while (resposta != 0)
            {
                switch (resposta)
                {
                    case 1:
                        AdicionarPessoas();
                        break;
                    case 2:
                        ImprimeLista();
                        break;
                }

                ImprimirMenu();
                resposta = int.Parse(Console.ReadLine());
            }
        }
        private static void AdicionarPessoas()
        {
            Console.Write("Digite o nome da pessoa:");
            var nomePessoa = Console.ReadLine();

            Console.Write("Digite a Idade da pessoa:");
            var idade = int.Parse(Console.ReadLine());

            var pessoa = new Pessoa();

            pessoa.Nome = nomePessoa;
            pessoa.Idade = idade;

            listaPessoas.Add(pessoa);
        }

        private static void ImprimeLista()
        {
            foreach (var pessoa in listaPessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}");
            }

            Console.ReadKey();
        }
  
        
       


    }
}
