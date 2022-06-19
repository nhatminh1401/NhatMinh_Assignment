using ShoppingCart.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }
        // public ICartRepository Cart{get;private set;}
        // public IApplicationUser ApplicationUser{get;private set;}
        // public IorderHeaderRepository OrderHeader{get;private set;}
        // public IOrder Detail Repository OrderDetail{get;private set;}
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Product = new ProductRepository(context);
            // Cart=new CartRepository(context);
            // ApplicationUser=new Application Repository(context);
            // OrderDetail=new OrderDetail Repository(context);
            // OrderHeader=new OrderHeaderRepository(context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
