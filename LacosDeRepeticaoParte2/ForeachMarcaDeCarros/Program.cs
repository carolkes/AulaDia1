using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachMarcaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarValoresMaiorIdade();
        }

        private static  void    ForeachListaDeCarros()
        {
            //Base de informações
            var informacoes = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaInformacoes = informacoes.Split(';');

            Console.WriteLine("Automóves cadastrados:");

            foreach (var item in listaInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Informe o nome do automóvel: ");
            var carroBusca = Console.ReadLine();

            foreach (var item in listaInformacoes)
            {
                var informacoesCarros = item.Split(',');

                var carro = informacoesCarros[0].Split(':')[1];
                var marca = informacoesCarros[1].Split(':')[1];
                var ano = informacoesCarros[2].Split(':')[1];

                if (carro == carroBusca)
                {
                    Console.WriteLine($"O carro {carro}, da marca {marca} é do ano {ano}.");
                }
  
            }

            Console.ReadKey();

        }
       
      
        private static  void    ListarValoresMaiorIdade()
        {
            var conteudo = "nome:Felipe/idade: 27; nome: Giomar/idade: 17; nome: Edson/idade: 19; nome: Ericledson/idade: 75; nome: Junior/idade: 45";

            var listaDeConteudo = conteudo.Split(';');

            foreach (var item in listaDeConteudo)
            {
                var quebraInformacao = item.Split('/');
                var idade = int.Parse(quebraInformacao[1].Split(':')[1]);
                var nome = quebraInformacao[0].Split(':')[1];

                if (idade >= 18)
                {
                    Console.WriteLine($"Nome: {nome}/Idade: {idade}");
                }
            }

            Console.ReadKey();

        }





    }
    

   
}
