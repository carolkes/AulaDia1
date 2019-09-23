using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livros = new LivrosController();

        //Instancimos "Carregamos a memória" nosso controlador dos usuários
        static UsuarioController usuarioController = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e Senha Inválidos");

            MostraMenuSistema();


            Console.ReadKey();
        }

        /// <summary>
        /// Mostra no console o meu disponível do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido !=0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Listar usuário");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Trocar de Usuário");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar um numero digitado
                menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
                //Executar próxima função
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamado do menu de listagem de usuários
                        MostraUsuarios();
                        break;
                    case 2:
                        MostrarLivro();
                        break;
                    case 3: break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    default:
                        break;
                }
            }  
        }
        private static  void    MostraUsuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuarioController.ListaDeUsuarios.ForEach(i => Console.WriteLine($"Login Usuário:{i.Login}"));
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza o procedimento completo de login dentro do sistema como solicitação de longin e senha pelo console assim como respectivas validaçoes que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool    RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);

        }
        
        

        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i => Console.WriteLine($"Meu livro é: {i.Nome}"));

            Console.ReadKey();

        }
     
    }
}
