using Mocanu_project.Entities;

namespace Mocanu_project.Models
{
    public class TrainerPostModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int StyleId { get; set; }
        public int ClubId { get; set; }

    }
}
