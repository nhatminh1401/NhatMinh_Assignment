using app.Models;
using Microsoft.EntityFrameworkCore;
using API.Models;

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


        public DbSet<API.Models.User>? User { get; set; }
    }
}
