using Microsoft.EntityFrameworkCore;
using Estacionamento.Models;

namespace Estacionamento.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}

