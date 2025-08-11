using Microsoft.EntityFrameworkCore;
using ProjetoEntityFramework.Model;

namespace ProjetoEntityFramework.Data
{
    // Gerencia a conexão e manipulação das entidades de dados.
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=lojinhas;trusted_connection=True;trustservercertificate=True;");
        }
    }
}
