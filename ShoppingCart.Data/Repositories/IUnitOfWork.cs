using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repositories
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{get;}
        IProductRepository Product { get; }
        // ICartRepository Cart{get;}
        // IApplicationUser ApplicationUser{get;}
        // IOrderHeaderRepository OrderHeader{get;}
        // IOrderDetail Repository OrderDetail{get;}
        void Save();
    }
}
