using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApiCoreRegistroImoveis.Model
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; } = string.Empty;
        
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
