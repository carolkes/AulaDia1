using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe pública**
    public class Cerveja
    {
        //Para adicionar a 'Key', ao digitar (ctrl + '.')
        //selecionamos a opção using...
        [Key] //Key = chave primária, auto incrementada
        public int Id { get; set; }
        //Aqui definimos a quantidade máxima de caracteres
        [StringLength(50)]//para nosso campo "Nome" dentro do banco
        [Required] // = not null do banco de dados
        //Identifica que este campo é obrigatório
        public string Nome { get; set;  }
        [StringLength(30)]//Tamanho máximo de caracteres para o tipo
        public string Tipo { get; set; }
        public double Alcool { get; set; }
    }
}
