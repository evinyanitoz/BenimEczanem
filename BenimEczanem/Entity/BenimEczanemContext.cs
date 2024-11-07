using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimEczanem.Entity
{
    public class BenimEczanemContext : DbContext
    {

        public DbSet<il> il { get; set; }
        public DbSet<ilce> ilce { get; set; }
    }
}
