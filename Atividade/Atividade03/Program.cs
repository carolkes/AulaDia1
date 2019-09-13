using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = SolicitaNome();
            Console.WriteLine($"Que bom ter você aqui {name}! Seja bem vindo(a).");
            var idade = SolicitaIdade(name);
            Console.ReadKey();

            
        }
        private static  string  SolicitaNome()
        {
            Console.WriteLine("Olá, tudo bem? Por favor, insira aqui seu nome completo:");
            return Console.ReadLine();
        }
        private static int SolicitaIdade(string nome) 
        {
         
            Console.WriteLine("Insira aqui também a sua idade, mas COM SINCERIDADE!!");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"Legal {nome}!! Bora beberrr!");
            else
                Console.WriteLine($"Que pena {nome}, fica pra uma próxima.. mas tem leite na geladeira! ");

            return idade;

        }

       
    }
}
