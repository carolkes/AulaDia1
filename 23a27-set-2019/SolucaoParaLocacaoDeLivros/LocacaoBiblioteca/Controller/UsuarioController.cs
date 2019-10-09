using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        
        /*DESENVOLVIMENTO PROJETO ATUAL 09.10.2019*/

        //Inserção
        public bool InserirLivro (Livro item)
        {

        }
        //Atualização
        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB
                .Livros
                .FirstOrDefault(x => x.Id == item.Id);

            if (livro == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }

            return true;
        }
        //Remoção
        public bool RemoverLivro(int id)
        {
            var livro = contextDB//Nosso banco de dados
                .Livros//Nossa tabela de livros
                .FirstOrDefault//Informamos item para desativar
                (x => x.Id == id);//regra de busca por id

            if (livro == null)//Verificamos se este item existe
                return false;//Caso não exista, sai do nosso método

            livro.Ativo = false;//Desativamos item

            contextDB.SaveChanges();//Salvamos em nosso banco

            return true;
        }
        //Listagem
        public IQueryable<Livro> GetLivros()
        {
            return contextDB //Acesso ao banco de dados
                .Livros //Acesso a nossa tabela de livros
                .Where(x => x.Ativo == true);//Filtro
        }
        
        /* DESENVOLVIMENTO PROJETO ANTERIOR
        //Criamos o construtor
        public UsuarioController()
        { }
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Login do usuário dentro do sistema</param>
        /// <param name="senha">Senha do usuário dentro do sistema</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            //Método que já está validado por ativo ou inativo
            return RetornaListaDeUsuarios()
                .Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="usuario">Novo usuario que sera adicionado a lista</param>
        public  void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = contextDB.IdContadorUsuarios++;
            //adiciono meu usuario a minha lista
            contextDB.ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Método que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns></returns>
        public  List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "Where(x=>x.Ativo)"
            return contextDB
                .ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public  void    RemoverUsuarioPorID(int identificadoID)
        {
            //Aqui usamos o método FirstOrDefaul para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            var usuario = contextDB.ListaDeUsuarios
                .FirstOrDefault(x => x.Id == identificadoID);
            if (usuario != null)
                usuario.Ativo = false;

        }*/
    }
}
