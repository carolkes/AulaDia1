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
        private LocacaoContext contextDB = new LocacaoContext();
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
        }
    }
}
