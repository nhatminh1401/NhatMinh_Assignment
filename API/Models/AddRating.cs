using API.Models.Products;

namespace API.Models
{
    public class AddRating
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Ratting { get; set; }
        public int ProductId { get; set; }
        public Product products { get; set; }
    }
}
