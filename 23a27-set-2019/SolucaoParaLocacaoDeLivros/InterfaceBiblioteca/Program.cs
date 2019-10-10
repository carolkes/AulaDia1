using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livros = new LivrosController();

        //Instancimos "Carregamos a memória" nosso controlador dos usuários
        static UsuarioController usuarios = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
            //if usuario.list.where(i => i.ativo == true)
            /*while (!RealizaLoginSistema())
                Console.WriteLine("Login e Senha Inválidos");*/

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
                Console.WriteLine("2 - Cadastro Usuários");
                Console.WriteLine("3 - Remover Usuário");
                Console.WriteLine("4 - Listar Livros");
                Console.WriteLine("5 - Cadastrar Livros");
                Console.WriteLine("6 - Remover Livro");
                Console.WriteLine("7 - Atualizar Livro");
                Console.WriteLine("8 - Trocar de Usuário");
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
                        //Metodo que inicializa a tela para adicionar um usuario
                        AdicionarUsuario();
                        break;
                    case 3://Metodo que inicializa a tela para remover um usuario
                        RemoverUsuario();
                        break;
                    case 4://Metodo que inicializa a tela para mostrar os livros
                        ListarLivro();
                        break;
                    //Metodo que inicializa a tela para adicionar um livro
                    case 5: InserirLivro();
                        break;
                    case 6:
                        RemoverLivro();
                        break;
                    case 7:
                        AtualizaLivro();
                        break;
                    case 8:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;     
                    default:
                        break;
                }
            }  
        }
        public static void AtualizaLivro()
        {
            Console.WriteLine("Atualizar Livro Por Id");

            Console.WriteLine("Insira o Id do livro que deseja atualiar:");
            var livroId = int.Parse(Console.ReadLine());

            var livro = livros.GetLivros()
                .FirstOrDefault(x => x.Id == livroId);

            if (livro != null)
            {
                Console.WriteLine("Informe um novo nome para o livro:");
                var novoNome = Console.ReadLine();

                livro.Nome = novoNome;

                var resultado = livros.AtualizarLivro(livro);

                if (resultado)
                    Console.WriteLine("Livro atualizado com sucesso!");
                else
                    Console.WriteLine("Erro ao atualizar livro");
            }
            else
                Console.WriteLine("Livro informado é inválido!");

            Console.ReadKey();
        }
        public static void RemoverLivro()
        {
            Console.WriteLine("Remover Livro do sistema:");

            livros
                .GetLivros()
                .ToList<Livro>()
                .ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome}"));

            Console.WriteLine("Informe o ID do livro que deseja desativar do sistema:");
            var livroId = int.Parse(Console.ReadLine());

            var resultado = livros.RemoverLivro(livroId);

            if (resultado)
                Console.WriteLine("Livro removido do sistema!");
            else
                Console.WriteLine("Erro ao remover livro!");

            Console.ReadKey();
        }
        /// <summary>
        /// Método que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        public static  void    InserirLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema!");
            //Informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos informação do usuário
            var nomeDoLivro = Console.ReadLine();
           
            var resultado = livros.InserirLivro(new Livro()
            {
                Nome = nomeDoLivro
            });

            if (resultado) //aqui usamos a condição if onde se o livro 
                Console.WriteLine("Livro cadastrado com sucesso!");//for cadastrado corretamente aparece a msg
            else
                //se não for cadastrado corretamente, erro
                Console.WriteLine("Erro ao cadastrar livro!");

            Console.ReadKey();
        }
        public static void ListarLivro()
        {
            Console.WriteLine("Listagem de Livros");

            livros.GetLivros()
                .ToList<Livro>()
                .ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Método que adiciona um novo usuario no sistema pelo console
        /// </summary>
        public static  void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário dentro do sistema:");
            Console.WriteLine("Informe um Login:");
            var loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe uma senha:");
            var senhaUsuario = Console.ReadLine();

            usuarios.AdicionarUsuario(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });
            Console.WriteLine("Longin e senha cadastrados!");
            Console.ReadKey();
        }
        public static  void    MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuarios
                .ListarUsuario()
                .ForEach(x => 
                Console.WriteLine($"Id: {x.Id} Login Usuário:{x.Login}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza o procedimento completo de login dentro do sistema como solicitação de longin e senha pelo console assim como respectivas validaçoes que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        public static bool    RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarios.LoginSistema(usuario);

        }
        public static void RemoverUsuario()
        {
            Console.WriteLine("Remover Usuário Do Sistema");

            usuarios.ListarUsuario()
                .ToList<Usuario>()
                .ForEach(x => 
                Console.WriteLine($"Id: {x.Id} Login:{x.Login}"));

            Console.WriteLine("Informe o ID do usuário que deseja remover:");
            var usuarioId = int.Parse(Console.ReadLine());

            usuarios.RemoverUsuario(usuarioId);
            Console.WriteLine("Usuário Removido!");
            Console.ReadKey();

        }





    }
}
