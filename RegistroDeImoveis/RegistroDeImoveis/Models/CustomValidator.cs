using RegistroDeImoveisMigrationApiWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        private string Fild { get; set; }

        public CustomValidator(string fildName)
        {
            Fild = fildName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Fild == "Nome")
            {
                MigrationContext db = new MigrationContext();

                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já cadastrado");
            }
            else
                if (Fild == "DataNascimento")
            {
                if(Convert.ToDateTime(value) > DateTime.Now.AddYears(-18))
                    return new ValidationResult("Idade menor que o permitido para realizar cadastro (18 anos)");

                if (Convert.ToDateTime(value) < DateTime.Now.AddYears(-150))
                    return new ValidationResult("Idade maior que permitido para realizar cadastro (150 anos)");
            }
            return ValidationResult.Success;
        }
    }
}