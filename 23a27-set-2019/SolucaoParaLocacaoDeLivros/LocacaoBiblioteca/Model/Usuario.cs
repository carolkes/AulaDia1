using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{ //definir classe como pública
    public class Usuario : ControleDeUsuario
    {
        [Key] // primary key and identity(1,1)
        public  int Id { get; set; }

        [MaxLength(30)] // definimos quantidade máxima de caracteres
        [Required] //definimos campo obrigatório
        public string Login { get; set; }

        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }

    }
}
