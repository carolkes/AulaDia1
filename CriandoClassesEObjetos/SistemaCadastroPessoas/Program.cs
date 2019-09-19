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

            cadastroPessoas.Add(objetoPessoa);

            cadastroPessoas.ForEach(i => Console.WriteLine($@"Agora vamos confirmar seus dados: 
Nome: {i.Nome}
Idade: {i.Idade} 
Sexo: {i.Sexo}
Altura: {i.Altura}"));

            Console.WriteLine("Cadastro Realizado! Obrigada!");
            Console.ReadKey();











        }
            
            
        

    }
}
