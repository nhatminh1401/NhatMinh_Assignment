using API.Models.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class UpdateRating
    {
        public string Comment { get; set; }
        public int Ratting { get; set; }
        public IEnumerable<Product> products { get; set; }

    }
}
