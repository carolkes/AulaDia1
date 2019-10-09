using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixar pública**
    public class Usuario : ControleUsuario
    {
        [Key] //Definindo como primary key e identity(1,1)
        public int In { get; set; }

        [MaxLength(50)] //delimitamos um tamanho máximo para o campo string
        public string Nome { get; set; }

        [MaxLength(30)] //delimitamos o tamanho do campo
        [Required]//Definimos que este campo é obrigatório
        public string Login { get; set; }

        [MaxLength(30)] //delimitamos o tamanho do campo
        [Required]//Definimos que este campo é obrigatório
        public string Senha { get; set; }
    }
}
