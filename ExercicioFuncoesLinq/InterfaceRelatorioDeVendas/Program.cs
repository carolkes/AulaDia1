using MenuRelatorio.CarroController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRelatorioDeVendas
{
    class Program
    {
        static VendasController vendasController = new VendasController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE VENDAS DE CARRO");

            ListaDeVendas();

            Console.ReadKey();
        }
        private static void ListaDeVendas()
        {

                vendasController.RetornaListaDeVendas().ForEach(i => Console.WriteLine($"Id: {i.Id} Carro: {i.Nome} Valor: {i.Valor} Quantidade {i.Quantidade} Data de venda: {i.DataDeVenda}"));

            Console.ReadKey();

        }
    }

}
