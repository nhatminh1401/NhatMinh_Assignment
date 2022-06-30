namespace API.Models.Products
{
    public class UpdateProduct
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }
        public Category category { get; set; }
    }
}
