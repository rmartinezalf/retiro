using Microsoft.EntityFrameworkCore;
using Retiros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retiros.Contexts
{
    public class AppDbContext : DbContext
    {
        internal object movimiemtos;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entities.Cliente> Cliente { get; set; }
        public DbSet<Cuentas> cuentas { get; set; }
        public DbSet<Parametros> parametros { get; set; }
        public DbSet<Movimientos> movimientos { get; set; }
    }

}
