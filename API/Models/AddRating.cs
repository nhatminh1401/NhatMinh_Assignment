using API.Models.Products;

namespace API.Models
{
    public class AddRating
    {
        public string Comment { get; set; }
        public int Ratting { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}
