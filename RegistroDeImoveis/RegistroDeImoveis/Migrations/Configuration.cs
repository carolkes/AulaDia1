namespace RegistroDeImoveisMigrationApiWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RegistroDeImoveisMigrationApiWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroDeImoveisMigrationApiWeb.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroDeImoveisMigrationApiWeb.Models.MigrationContext context)
        {
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario() {
                Nome = "Carol",
                DataNascimento = new DateTime(1995,11,21),
                Email = "carol@gmail.com"
            });

            context.SaveChanges();

            var proprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Carol").Id;

            context.Imoveis.AddOrUpdate(x => x.ProprietarioId, new Models.Imovel() {
                Cep = "89010401",
                Logradouro = "Nereu Ramos",
                Bairro = "Jardim Blumenau",
                Numero = 515,
                Municipio = "Blumenau",
                ProprietarioId = proprietarioId
            });

            context.SaveChanges();
        }
    }
}
