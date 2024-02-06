using Microsoft.EntityFrameworkCore;
using SLClientesAPI.Model;

namespace SLClientesAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Empresas> Empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SLCLIENTES;
                                         Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
