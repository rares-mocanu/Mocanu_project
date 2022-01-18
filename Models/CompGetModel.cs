using System.Linq.Expressions;

namespace Mocanu_project.Models
{
    public class CompGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Date { get; set; }
        public static Expression<Func<Entities.Competition, CompGetModel>> Projection => competition => new CompGetModel()
        {
            Id = competition.Id,
            Name = competition.Name,
            Date = competition.Date,
        };

    }
}
