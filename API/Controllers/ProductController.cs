using API.Data;
using API.Models;
using API.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;
        public ProductController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await dbContext.Products.ToListAsync());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            var product = await dbContext.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProduct addProduct)
        {
            var category1 = dbContext.Categories.Find(addProduct.category);
            var product = new Product()
            {

                ProductName = addProduct.ProductName,
                Description = addProduct.Description,
                Price = addProduct.Price,
                ImageTitle = addProduct.ImageTitle,
                //categoryId = addProduct.categoryId,
                category = category1,
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            return Ok(product);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, UpdateProduct updateProduct)
        {
            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                product.ProductName = updateProduct.ProductName;
                product.Description = updateProduct.Description;
                product.Price = updateProduct.Price;
                product.ImageTitle = updateProduct.ImageTitle;
                


                await dbContext.SaveChangesAsync();

                return Ok(product);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                dbContext.Remove(product);
                await dbContext.SaveChangesAsync();
            }
            return NotFound();
        }
        
    }
}
