using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhileIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;


            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskToAge(nome);

            }
          
            Console.WriteLine($"Suas informações: Nome {nome} e sua idade {idade}");
            Console.ReadKey();
        }

        private static void ShowInitAppText()
        {
            Console.WriteLine("************************");
            Console.WriteLine("**Olá! Seja Bem Vindo!**");
            Console.WriteLine("************************");
        }

        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? Sim(1) Não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }

        private static int AskToAge(string  nome)
        {
            Console.WriteLine("Informe a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{nome} você pode beber!!");
            else
            
                Console.WriteLine($"{nome} você ainda não pode beber..");

            return idade;
        }
        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }

        
        

      
       
     



        









        
        
       
        




    }
}   
	

	
