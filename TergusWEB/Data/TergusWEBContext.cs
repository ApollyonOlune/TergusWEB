using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TergusWEB.Models;

namespace TergusWEB.Data
{
    public class TergusWEBContext : DbContext
    {
        public TergusWEBContext (DbContextOptions<TergusWEBContext> options)
            : base(options)
        {
        }

        public DbSet<TergusWEB.Models.Cliente> Cliente { get; set; }

        public DbSet<TergusWEB.Models.Funcionario> Funcionario { get; set; }

        public DbSet<TergusWEB.Models.Processo> Processo { get; set; }
    }
}
