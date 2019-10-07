using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        //[Required] campo obrigatório a ser preenchido
        //[StringLength(30)] nome com no máximo 30 caracteres
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
