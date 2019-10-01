using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            MostraMenuRelatorio();

            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

           
            Console.ReadKey();
        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();

            Console.WriteLine("Menu de Relatórios");
            Console.WriteLine("1 - Relatório mensal");
            Console.WriteLine("2 - Relatório anual");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while(menuEscolhido !=0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            //Obtemos a informação do mês
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //Passamos o mês na mesma função para obter as vendas
                            var listaPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            listaPeriodoEscolhido
                                //Aqui imprimimos as informações para o usuário
                                .ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaPeriodoEscolhido
                                //Somamos todos os registros multiplicando as vendas pela quantidade vendida
                                .Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaPeriodoEscolhido.Average(x => x.Valor * x.Quantidade);

                            //Mostramos o mes escolhido e o valor total
                            Console.WriteLine($"Total do mês {mesEscolhido} é de {totalMes.ToString("C")}");
                            //Mostramos o mês escolhido e o valor médio vendido no mês
                            Console.WriteLine($"A média do mês {mesEscolhido} é de {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        public static void ImprimeInformacoes (Venda vendas)
        {
            Console.WriteLine(
                string.Format(
                    //o - do (-3) faz a informação começar da esquerda para a direita
                    "Id: {0,-3} Carro: {1,-20} Valor: {2,-20} Quantidade: {3,-10} Data: {4,-12}", 
                    vendas.Id, 
                    vendas.Carro, 
                    vendas.Valor.ToString("C"), 
                    vendas.Quantidade, 
                    vendas.Data.ToShortDateString()));
        }
    }
}
