using Microsoft.EntityFrameworkCore;
using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Concrete.EntityFramework.Context
{
    public class ShoppingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CEMRE\SQLEXPRESS;initial catalog=Shopping;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
