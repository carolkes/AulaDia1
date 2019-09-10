using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro pelo numero de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado: ");
            //Parte do código que recebe as informações de registro do livro e coloca na váriavel numeroDoLivro para utlizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizou a comparação das informações do livro informado com o que tenho disponível em estoque

            if (numeroDoLivro == "123456")
            {
                //Informo que este livro já está locado
                Console.WriteLine("Livro Indisponível!");
                Console.ReadKey();

                //Finaliza o método
                return;
            }
            else
            {
                Console.WriteLine("Deseja locar o livro? (1)Sim (2)Não");
                var resposta = Console.ReadLine();
                if(resposta == "1")
                {
                    Console.WriteLine("Livro Locado.");
                    Console.ReadKey();
                    return;

                }
            }
            
        }
    }
}
