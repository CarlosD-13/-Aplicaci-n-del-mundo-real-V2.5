using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroLinea_Futuro.Models
{
    public class BoletosContext : DbContext
    {
        public BoletosContext(DbContextOptions<BoletosContext> options) : base(options)
        {
              
        }
        public DbSet<Boletos> Boletos { get; set; }
    }
}
