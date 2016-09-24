using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercicio.Models
{
    public class DataContext : DbContext 
    {
        public DataContext() : base("teste") { }

        public DbSet<CalcPrecoPrazo> CalcPrecoPrazo { get; set; }
    }
}