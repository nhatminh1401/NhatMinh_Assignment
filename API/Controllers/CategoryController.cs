using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public CategoryController (ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            return Ok(await dbContext.Categories.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategory addCategory)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = addCategory.CategoryName,
                Description = addCategory.Description,

            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return Ok(category);
        }
    }
}
