using System.Linq.Expressions;

namespace Mocanu_project.Models
{
    public class ClubGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public static Expression<Func<Entities.Club, ClubGetModel>> Projection => club => new ClubGetModel()
        {
            Id = club.Id,
            Name = club.Name,
            Address = club.Address,
            Email = club.Email
        };
    }
}
