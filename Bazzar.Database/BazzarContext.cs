using Bazzar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzar.Database
{
    public class BazzarContext : DbContext
    {
        public BazzarContext() : base("BazzarConnection"){}
        public DbSet<Catagory> Catagories{ get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
