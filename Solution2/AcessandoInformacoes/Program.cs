using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void    MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Cálculo de Área");
            Console.WriteLine("2 - Imagem Árvore");
            Console.WriteLine("3 - Lista de Cervejas");
            Console.WriteLine("4 - Lista de Carros");
            Console.WriteLine("5 - Sair do Sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1: {
                        CalculoArea();
                        MenuSistema();
                    }
                    break;
                case 2: {
                        ImagemArvore.ExecutarImagemArvore();
                        MenuSistema();
                    }
                    break;
                case 3: {
                        MostrarListas.ListagemCervejas();
                        MenuSistema();
                    }break;
                case 4:
                    {
                        MostrarListas.ListagemMarcasCarros();
                        MenuSistema();
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Tchauuuu!!");
                        Thread.Sleep(1000);
                        return;
                    }
                default:
                    break;
            }
        }
        public  static void CalculoArea()
        {
            Console.WriteLine("Informa o lado do quadrado:");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }

       
    }
}
