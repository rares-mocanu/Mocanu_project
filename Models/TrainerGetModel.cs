using System.Linq.Expressions;

namespace Mocanu_project.Models
{
    public class TrainerGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string StyleName { get; set; }
        public string ClubName { get; set; }
        public static Expression<Func<Entities.Trainer, TrainerGetModel>> Projection => trainer => new TrainerGetModel()
        {
            Id = trainer.Id,
            Name = trainer.Name,
            StyleName = trainer.style.Name,
            ClubName = trainer.Club.Name
        };

    }
}
