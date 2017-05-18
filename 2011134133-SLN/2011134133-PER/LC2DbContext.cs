using _2011134133_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011134133_PER
{
    public class LC2DbContext : DbContext
    {
        public DbSet<ATM> AtmS { get; set; }
        public DbSet<BaseDatos> BaseDato { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<DispensadorEfectivo> DispensadorEfectivos { get; set; }
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<RanuraDeposito> RanuraDepostio { get; set; }
        public DbSet<Retiro> Retiros { get; set; }
        public DbSet<Teclado> Teclados { get; set; }

    } 
}
