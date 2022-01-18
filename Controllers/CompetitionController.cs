using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Models;

namespace Mocanu_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompetitionController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCompetition(CompPostModel model)
        {
            var competition = new Competition
            {
                Id = model.Id,
                Name = model.Name,
                Prize = model.Prize,
                Date = model.Date
            };

            await _context.AddRangeAsync(competition);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCompetitions()
        {
            var competitions = await _context.Competitions.Select(CompGetModel.Projection).ToListAsync();

            return Ok(competitions);
        }

    }
}
