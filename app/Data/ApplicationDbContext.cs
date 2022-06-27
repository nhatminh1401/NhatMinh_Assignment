using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) 
            :base(options)
        {

        }
    }
}
