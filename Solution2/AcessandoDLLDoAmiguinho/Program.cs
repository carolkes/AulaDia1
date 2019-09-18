using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;
	
namespace AcessandoDLLDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {

            var dllColega = new MinhaBiblioteca.CalculosDeArea();

            Console.WriteLine("Insira aqui o valor que deseja calcular:");
            Console.WriteLine($"Resultado: {dllColega.CalculaAreaQuadrado(int.Parse(Console.ReadLine()))}");
            

            Console.ReadKey();
        }
    }
}
