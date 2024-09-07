using Microsoft.EntityFrameworkCore;
using SistemaContratos.Models;

namespace SistemaContratos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }

        public DbSet<ContratoModel> Contratos { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }

    }
}
