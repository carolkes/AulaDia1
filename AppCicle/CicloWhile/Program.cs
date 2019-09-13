using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            //informaçao convertida para string / KeyChar é como se fosse a letra de uma palavra
            //para passar uma string para int, utilizar o 'Parse'
            while (AskToContinue() == 1) 
            //"1" para converter pra string ou alterar a var para int, acrescentando int.Parse
            {
                
            }
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static  void    ShowInitAppText()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("----Seja Bem Vindo!----");
            Console.WriteLine("-----------------------");

        }
        /// <summary>
        /// Método para realizar a pergunta que se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static  int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? Sim(1) Não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }
    }
}
