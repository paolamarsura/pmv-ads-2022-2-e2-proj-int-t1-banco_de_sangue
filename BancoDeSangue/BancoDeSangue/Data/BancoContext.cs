using BancoDeSangue.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<InstituicaoModel> Instituicoes { get; set; }
    }
}
