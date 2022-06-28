using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ContactsAPIDbContext dbContext; 
        public ProductController (ContactsAPIDbContext dbContext)
        {
            this .dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await dbContext.Products.ToListAsync());
        }
    }
}
