using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Olá! Seja Bem Vindo!!");
            var usuario = SolicitaNome();
            Console.WriteLine($"Que bom ter você aqui {usuario}, Seja bem vindo(a)!");
            var idade = SolicitaIdade();
            Console.WriteLine($"Pra quem tem {idade} já fez muita merda heinn! rsrs");
            Console.ReadKey();
            

        }
        private static string SolicitaNome()
        {
            Console.WriteLine($"Por favor, escreva aqui seu nome completo:");
            return (Console.ReadLine());
        }
        private static string SolicitaIdade()
        {
            Console.WriteLine("Me conte, qual a sua idade?");
            return (Console.ReadLine());
        }


                    
    }
}
