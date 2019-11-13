using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExercicioFinalUsuarios.Models
{
    public partial class BancoDeDadosUsuariosContext : DbContext
    {
        public BancoDeDadosUsuariosContext()
        {
        }

        public BancoDeDadosUsuariosContext(DbContextOptions<BancoDeDadosUsuariosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Nome).HasMaxLength(50);

                entity.Property(e => e.Senha)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
