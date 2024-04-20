using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2019TM602_2020MZ602.Models
{
    public class usuariosDbContext : DbContext
    {
        public usuariosDbContext(DbContextOptions<usuariosDbContext> options) : base(options) { }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<puestos> puestos { get; set; }

    }
}
