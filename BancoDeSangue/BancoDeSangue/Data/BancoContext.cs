using BancoDeSangue.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoDeSangue.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<InstituicaoModel> Instituicoes { get; set; }

        public DbSet<FormularioModel> Formulario { get; set; }
    }
}
