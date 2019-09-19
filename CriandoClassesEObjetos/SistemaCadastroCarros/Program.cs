using SistemaCadastroCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastroCarros = new List<Carro>();

            var objetoCarros = new Carro();

            Console.WriteLine("Olá! Cadastre seu carro aqui.");
            Console.WriteLine("Insira aqui a marca do seu carro:");
            objetoCarros.Marca = Console.ReadLine();

            Console.WriteLine("Insira o modelo do seu carro:");
            objetoCarros.Modelo = Console.ReadLine();

            Console.WriteLine("Insira o ano do seu carro:");
            objetoCarros.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do seu carro:");
            objetoCarros.Valor = double.Parse(Console.ReadLine());

            cadastroCarros.ForEach(i => Console.WriteLine($"Confirmando os dados do seu carro:{i.Marca}, {i.Modelo}, {i.Ano}, {i.Valor}"));




        }


    }
}
