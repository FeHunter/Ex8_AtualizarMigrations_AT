using Ex8_AtualizarMigrations_AT.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex8_AtualizarMigrations_AT.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) {}
    }
}
