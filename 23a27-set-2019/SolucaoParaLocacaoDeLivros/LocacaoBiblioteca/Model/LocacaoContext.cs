using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    //através do ':' Definimos nossa herança
    public class LocacaoContext : DbContext //herdamos toda caixa de
        //ferramentas do entityframework
    {
        //Definindo a tabela de Usuarios no banco de dadis
        public DbSet<Usuario> Usuarios { get; set; }

        //Definindo a tabela de livros no banco de dados
        public DbSet<Livro> Livros { get; set; }


        /* DESENVOLVIMENTO DE PROJETO ANTERIOR
         * 
        //propriedade que armazena o ID dos livros adicionados ao sistema
        public int IdContadorLivros { get; set; } =1;
        public int IdContadorUsuarios { get; set; } = 1;
        /// <summary>
        /// Método construtor que repara nossa classe LocacaoCOntext
        /// </summary>
        public LocacaoContext()
        {
            //criamos uma lista de livros em memória
            ListaDeLivros = new List<Livro>();
            //criamos uma lista de usuarios em memória
            ListaDeUsuarios = new List<Usuario>();

            //Adicionamos os livros
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                //Informo apea o nome do livro a adicionar
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Segundo Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Era Uma Vez.." 
            });
            //Adicionamos o usuário
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123",
            });
        }

        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }*/
    }
}
