using MenuRelatorio.CarroController;
using MenuRelatorio.Controller;
using MenuRelatorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRelatorioDeVendas
{
    class Program
    {
        static CarroController carroController = new CarroController();
        static UsuarioController usuarioController = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE VENDAS DE CARRO");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e Senha Inválidos");

            MostraMenuSistema();
 
            Console.ReadKey();
        }
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE VENDAS DOS CARRO");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Listar Vendas");
                Console.WriteLine("2 - Relatório Mensal");
                Console.WriteLine("3 - Sair do Sistema");

                int.TryParse(Console.ReadKey()
                    .KeyChar.ToString(), out menuEscolhido);

                switch (menuEscolhido)
                {
                    case 1:
                        MostraMenuSistema();
                        break;
                    case 2:
                        MostrarListaDeVendas();
                        break;

                }
            }

        }
        private static void MostrarListaDeVendas()
        {
            carroController.RetornaListaDeVendas().ForEach(i => Console.WriteLine($"Id: {i.Id} Carro: {i.Nome} Valor: {i.Valor} Quantidade {i.Quantidade} Data de venda: {i.DataDeVenda}"));

            Console.ReadKey();
        }
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);

        }
    }

}
