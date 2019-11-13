using RegistroDeImoveis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveisMigrationApiWeb.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        [CustomValidator("Nome")]
        public string Nome { get; set; } = string.Empty;
        [CustomValidator("DataNascimento")]
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}