using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Models;

namespace Mocanu_project.Controllers
{
    public class ClubCompController : Controller
    {
        private readonly AppDbContext _context;

        public ClubCompController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> CreateClubComp(ClubCompPostModel model)
        {
            var clubComp = new ClubCompetition()
            {
                CompetitionId = model.CompetitionId,
                ClubId = model.ClubId
            };
            await _context.ClubCompetitions.AddAsync(clubComp);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet("get-participants-of-id")]
        public async Task<IActionResult> GetCompClubs(int id)
        {
            var clubs = await _context.ClubCompetitions.Where(x => x.CompetitionId == id).Select(ClubCompGetModel.Projection).ToListAsync();
            return Ok(clubs);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCompClub(int id)
        {
            var clubcomp = await _context.ClubCompetitions.FirstOrDefaultAsync(clubcomp => clubcomp.Id == id);
            _context.ClubCompetitions.Remove(clubcomp);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
