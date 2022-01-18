using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Models;

namespace Mocanu_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClubController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClubController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetClubs()
        {
            var trainers = await _context.Clubs.Select(ClubGetModel.Projection).ToListAsync();

            return Ok(trainers);
        }

        [HttpGet("get-trainers")]
        public async Task<IActionResult> GetClubTrainers(int id)
        {
            var trainers = await _context.Trainers.Where(x => x.ClubId == id).Select(TrainerGetModel.Projection).ToListAsync();

            return Ok(trainers);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClub(ClubPostModel model)
        {
            var club = new Club
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                Email=model.Email
            };

            await _context.AddRangeAsync(club);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
