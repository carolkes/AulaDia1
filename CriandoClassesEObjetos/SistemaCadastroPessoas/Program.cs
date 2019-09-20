using SistemaCadastroPessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCadastroPessoas
{
    class Program
    {

        static void Main(string[] args)
        {
            var cadastroPessoas = new List<Pessoa>();
            bool rodando = true;
            Console.WriteLine("Olá! Seja bem vindo.");
            Console.WriteLine("Pressione qualquer tecla para iniciar o cadastro...");
            Console.ReadKey();

            while (rodando)
            {
                Console.Clear();
                try
                {
                    Pessoa pessoa = BuscarDados();
                    cadastroPessoas.Add(pessoa);
                    Console.WriteLine("Cadastro Realizado! Obrigada!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu algum erro ao cadastrar pessoa.");
                }

                Console.WriteLine("Gostaria de continuar cadastro? (1) sim (0) não");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    cadastroPessoas.ForEach(i =>
                    {
                        Console.WriteLine($@"Agora vamos confirmar seus dados:
Nome: {i.Nome}
Idade: {i.Idade}
Sexo: {i.Sexo}
Altura: {i.Altura}");
                        Console.WriteLine("--------------------------------------------------");
                    });
                    rodando = false;
                    break;
                }
            }
            Console.ReadKey();
        }
    
        static  Pessoa  BuscarDados()
        {

            var objetoPessoa = new Pessoa();

            Console.WriteLine("Olá! Seja bem vindo!");

            Console.WriteLine("Nome completo:");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo:");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Altura:");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());

            return objetoPessoa;

           
 


        }
            
            
        

    }
}
