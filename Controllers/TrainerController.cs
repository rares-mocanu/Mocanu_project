using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Models;

namespace Mocanu_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TrainerController : Controller
    {
        private readonly AppDbContext _context;

        public TrainerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainer(TrainerPostModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return BadRequest("Invalid object. Model is null");
            }

            var trainer = new Trainer()
            {
                Name = model.Name,
                StyleId = model.StyleId,
                ClubId = model.ClubId
            };

            await _context.Trainers.AddRangeAsync(trainer);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetTrainers()
        {
            var trainers = await _context.Trainers.Select(TrainerGetModel.Projection).ToListAsync();

            return Ok(trainers);
        }
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetTrainerById(int id)
        {
            var trainer = await _context.Trainers.Select(TrainerGetModel.Projection).FirstOrDefaultAsync(trainer => trainer.Id == id);
            return Ok(trainer);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTrainer(int id)
        {
            var trainer = await _context.Trainers.FirstOrDefaultAsync(trainer => trainer.Id == id);
            if (trainer == null)
            {
                return BadRequest("Trainer doesn't exist");
            }

            _context.Trainers.Remove(trainer);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> EditTrainer(int id, TrainerPostModel model)
        {
            var trainer = await _context.Trainers.FirstOrDefaultAsync(trainer => trainer.Id == id);

            if (trainer == null)
            {
                return BadRequest("Trainer doesn't exist");
            }

                trainer.Name = model.Name;
                trainer.StyleId = model.StyleId;
                trainer.ClubId = model.ClubId;

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
