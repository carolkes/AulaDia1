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
        private int IdContador = 1;
        public  LivrosController()
        {
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro"
            });
        }
        private List<Livro> ListaDeLivros { get; set; }
        /// <summary>
        /// Método que adiciona o livro em nossa lista já "Instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public  void    AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            //Adicionamos o livro em nossa lista
            ListaDeLivros.Add(parametroLivro);
        }
        public  List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
    }
}
