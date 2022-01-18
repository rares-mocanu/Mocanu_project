using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Models;

namespace Mocanu_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StyleController : Controller
    {
        private readonly AppDbContext _context;

        public StyleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStyle(StylePostModel model)
        {

            var style = new Style()
            {
                Id = model.Id,
                Name = model.Name,
                Type = model.Type,
                Description = model.Description
            };

            await _context.Styles.AddRangeAsync(style);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetStyles()
        {
            var trainers = await _context.Styles.Select(StyleGetModel.Projection).ToListAsync();

            return Ok(trainers);
        }

    }
}
