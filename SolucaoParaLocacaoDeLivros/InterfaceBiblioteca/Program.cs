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
        static LivrosController livrosController = new LivrosController();

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
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Trocar de Usuário");
                Console.WriteLine("5 - Cadastro Usuários");
                Console.WriteLine("6 - Remover Usuário");
                Console.WriteLine("7 - Remover Livro");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar um numero digitado
                // menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out menuEscolhido);
                //Executar próxima função
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamado do menu de listagem de usuários
                        MostrarUsuarios();

                        break;
                    case 2:
                        //Metodo que inicializa a tela para mostrar os livros
                        MostrarLivro();
                        break;
                    //Metodo que inicializa a tela para adicionar um livro
                    case 3: AdicionarLivro();
                        break;
                    case 4:RemoverLivroPorID();
                        break;
                    case 5:
                        //Metodo que inicializa a tela para adicionar um usuario
                        AdicionarUsuario();
                        break;
                    case 6:
                        //Metodo que inicializa a tela para remover um usuario
                        RemoverUsuarioPeloID();
                        break;
                    case 7:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;     
                    default:
                        break;
                }
            }  
        }
        private static void RemoverLivroPorID()
        {
            Console.WriteLine("Remover livro do sistema:");
            MostrarLivro();

            Console.WriteLine("Informe o ID do livro que deseioja desativar do sistema:");
            var livroID = int.Parse(Console.ReadLine());

            livrosController.RemoverLivroPorID(livroID);
            Console.WriteLine("Livro desativado do sistema!");
            Console.ReadKey();
        }
        private static  void    RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover um usuário pelo ID no sistema:");
            //Método que mostra os usuarios criados anteriormente
            MostrarUsuarios();

            Console.WriteLine("Informe o ID que deseja destivar no sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            usuarioController.RemoverUsuarioPorID(usuarioID);
            Console.WriteLine("Usuário desativado com sucesso!");
            Console.ReadKey();
        }
        /// <summary>
        /// Método que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static  void    AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema!");
            //Informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos informação do usuário
            var nomeDoLivro = Console.ReadLine();
            //"livrosController" livros controle e nosso "objeto" em memória
            //com isso temos disponível nele ferramentas que nos ajudam a realizar as tarevas
            //como adicionar um item a nossa lista de livros
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                //com o sinal de apenas um "=" temos atribuição, passagem de valor
                Nome = nomeDoLivro
            });
            //Indico que finalizamos o processo de cadastro do livro, assim o usuáio já sabe que o mesmo foi realizado sem erros
            Console.WriteLine("Livro cadastrado com sucesso!");
            //ReadKey apenas para que ele vizualize esta informação
            Console.ReadKey();
        }
        /// <summary>
        /// Método que adiciona um novo usuario no sistema pelo console
        /// </summary>
        private static  void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário dentro do sistema:");
            Console.WriteLine("Informe um Login:");
            var loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe uma senha:");
            var senhaUsuario = Console.ReadLine();

            usuarioController.AdicionarUsuario(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });
            Console.WriteLine("Longin e senha cadastrados!");
            Console.ReadKey();
        }
        private static  void    MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id: {i.Id} Login Usuário:{i.Login}"));
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

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);

        }
        private static void MostrarLivro()
        {
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"Id: {i.Id} Meu livro é: {i.Nome}"));

            Console.ReadKey();

        }

     
    }
}
