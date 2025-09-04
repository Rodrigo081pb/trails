using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;
using Microsoft.Extensions.Configuration;

namespace minimal_api.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
            if (!this.Database.IsSqlServer())
            {
                throw new InvalidOperationException("O DbContexto não foi configurado corretamente para usar SQL Server.");
            }
        }

        public DbSet<Admin> Admins { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1, // Valor fixo para o seed
                    Email = "administrador@sigma.com",
                    Nome = "Administrador",
                    Senha = "123Senha",
                    Perfil = "Adm",

                }
            );
        }

    }
}
