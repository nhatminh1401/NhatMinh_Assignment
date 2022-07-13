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

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> GetCategory([FromBody] int id)
        //{
        //    var category = await dbContext.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(category);
        //}

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCategory([FromRoute] int id)
        {
            var category = await dbContext.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
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
                
                CategoryName = addCategory.CategoryName,
                Description = addCategory.Description,

            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return Ok(category);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCategory([FromRoute] int id, UpdateCategory updateCatagory)
        {
            var category = await dbContext.Categories.FindAsync(id);

            if (category != null)
            {
                category.Description = updateCatagory.Description;
                category.CategoryName = updateCatagory.CategoryName;


                await dbContext.SaveChangesAsync();

                return Ok(category);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            var category = await dbContext.Categories.FindAsync(id);

            if (category != null)
            {
                dbContext.Remove(category);
                await dbContext.SaveChangesAsync();
                return Ok(dbContext.Categories.ToListAsync());
            }
            return NotFound();
        }
    }
}
