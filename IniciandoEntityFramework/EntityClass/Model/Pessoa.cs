using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key]//Aqui temos uma anotação que indica que nossa chave é
             // o campo logo a baixo da nossa anotação e a palavra [key]
             //significa que ele é nossa chave primária
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}
