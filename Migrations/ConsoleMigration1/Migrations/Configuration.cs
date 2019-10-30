namespace ConsoleMigration1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigration1.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMigration1.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMigration1.Model.MigrationContext context)
        {
            context.Usuarios.AddOrUpdate(x => x.Nome == "Carol", new Model.Usuario()
            {
                Nome = "Carol",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br",
                Nivel = Model.Nivel.Administrador
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
