using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {

            cervejaController.SetCervejaContext(new Cerveja()
            {
                Id = cervejaController.GetCervejaContext().Count + 1,
                Nome = "Skol",
                Litros = 0.75,
                Alcool = 4.5,
                Valor = 5.50
            });

            cervejaController.GetCervejaContext().ForEach(
                x => Console.WriteLine($"Id: {x.Id} - Nome: {x.Nome} - Litros: {x.Litros} - Valor: {x.Valor} - Teor Alcoolico: {x.Alcool}"));

            Console.WriteLine("Total Valor" + " " + cervejaController.SumValorCervejaContext().ToString("C"));
            Console.WriteLine("Total Litros" + " " + cervejaController.SumLitrosCervejaContext());


            Console.ReadKey();
        }
    }
}
