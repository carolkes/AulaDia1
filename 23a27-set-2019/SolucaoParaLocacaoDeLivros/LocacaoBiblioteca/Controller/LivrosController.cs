using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        LocacaoContext contextDB = new LocacaoContext();
  
        /*DESENVOLVIMENTO PROJETO ATUAL 09.10.2019*/

        //Inserção
        public bool InserirLivro(Livro item)
        {
            if (string//Nosso tipo que contém vários métodos prontos para string
                .IsNullOrWhiteSpace(item.Nome))//Método que identifica 
                                               // espaços em branco ou Valor null
                return false;

            contextDB.Livros.Add(item);
            contextDB.SaveChanges();

            return true;
        }
        //Atualização
        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB//banco de dados
                .Livros//Tabela
                .FirstOrDefault(x => x.Id == item.Id);//desativando item
            //por id

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


                         /*DESENVOLVIMENTO ANTERIOR
                          * 
        public  LivrosController()
        {
           
        }
        /// <summary>
        /// Método que adiciona o livro em nossa lista já "Instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public  void    AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.IdContadorLivros++;
            //Adicionamos o livro em nossa lista
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public  List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        public void RemoverLivroPorID(int identificadoLivroID)
        {
            var livro = contextDB.ListaDeLivros
                .FirstOrDefault(x => x.Id == identificadoLivroID);
            //Tratamento do valor quando ele não encontrar um livro com ID
            if (livro != null)
                livro.Ativo = false;  
        }*/
    }
}
