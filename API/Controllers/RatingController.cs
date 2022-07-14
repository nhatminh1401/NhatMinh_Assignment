using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;
        public RatingController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetRating()
        {
            return Ok(await dbContext.Ratings.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRating([FromRoute] int id)
        {
            var rate = await dbContext.Ratings.FindAsync(id);

            if (rate == null)
            {
                return NotFound();
            }
            return Ok(rate);
        }


        [HttpPost("{id}")]
        public async Task<IActionResult> AddRating(AddRating addRating, int id)
        {
            var rate = new AddRating()
            {
                Comment = addRating.Comment,
                ProductId = addRating.ProductId,
                Ratting = addRating.Ratting,
               
            };

            await dbContext.Ratings.AddAsync(rate);
            await dbContext.SaveChangesAsync();

            return Ok(rate);
        }
        

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRating([FromRoute] int id)
        {
            var rate = await dbContext.Ratings.FindAsync(id);

            if (rate != null)
            {
                dbContext.Remove(rate);
                await dbContext.SaveChangesAsync();
            }
            return NotFound();
        }
    }
}
