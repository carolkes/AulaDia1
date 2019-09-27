using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSistemaDeCerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            MostraMenuSistema();

            Console.ReadKey();
        }
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while(menuEscolhido !=0)
            {
                Console.Clear();

                Console.WriteLine("Menu Sistema De Cervejas");
                Console.WriteLine("1 - Lista de Cervejas");
                Console.WriteLine("2 - Cadastro de Cervejas");
                Console.WriteLine("3 - Valor Total do Custo das Cervejas");
                Console.WriteLine("4 - Valor Total de Litros das Cervejas");
                Console.WriteLine("0 - Sair do Sistema");

                Console.WriteLine("Digite menu escolhido:");
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        cervejaController.GetCervejas().ForEach(i => ImprimeInformacoes(i));
                        break;
                    case 2:
                        AdicionaCerveja();
                        break;
                    case 3:
                        ValorTotalCervejas();
                        break;
                    case 4:
                        ValorTotalEmLitros();
                        break;
                }
                Console.ReadKey();
            }
        }
        private static void ImprimeInformacoes(Cerveja cervejas)
        {
           
            Console.WriteLine(string.Format(
                "Id: {0,-3} Cerveja: {1,-22} Litros: {2,-5} Teor Alcóolico(%): {3,-5} Valor: {4,-12}",
                cervejas.Id, 
                cervejas.Nome, 
                cervejas.Litros, 
                cervejas.Alcool, 
                cervejas.Valor.ToString("C")));
        }
        private static void AdicionaCerveja()
        {
            Console.WriteLine("Informe o nome da cerveja que deseja cadastrar:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de litros:");
            var litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o teor alcóolico:");
            var teorAlcoolico = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor:");
            var valor = double.Parse(Console.ReadLine());

            cervejaController.AdicionarCerveja(new Cerveja()
            {
                Nome = nome,
                Litros = litros,
                Alcool = teorAlcoolico,
                Valor = valor
            });

            Console.WriteLine("Cerveja Cadastrada!");
            Console.ReadKey();
        }
        private static void ValorTotalCervejas()
        {
            Console.WriteLine("Valor total das cervejas:");
            var total =  cervejaController.ValorTotalCervejas().ToString("C");
            Console.WriteLine(total);
            Console.ReadKey();
        }
        private static void ValorTotalEmLitros()
        {
            Console.WriteLine("Valor total em litros:");
            var totalLitros = cervejaController.ValorTotalEmLitros();
            Console.WriteLine(totalLitros);
            Console.ReadKey();
        }


    }
}
