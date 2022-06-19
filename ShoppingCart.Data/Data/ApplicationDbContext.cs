using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        // public Dhsrt<Applicationser>Applicationisers(get;set;]
        // public DbSet<Cart>Carts{get;set;}
        // public Dbset<Orderileader>orderlleaders{get;set;}
        // public DbSet<OrderDetail>OrderDetails{get;set;}
    }
}
