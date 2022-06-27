using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class CartItem
    {
        public int UserId { get; set; }
        public int ProdductId { get; set; }
        public int ProductTypeId { get; set; }
        public int Quantity { get; set; }
    }
}
