using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public DbSet<PizzaCategory> PizzaCategories { get; set; }
        public  DbSet<PizzaAccount> Accounts { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) 
            :base(options)
        {

        }
    }
}
