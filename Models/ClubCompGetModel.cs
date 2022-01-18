using System.Linq.Expressions;

namespace Mocanu_project.Models
{
    public class ClubCompGetModel
    {
        public int CompetitionId { get; set; }
        public int ClubId { get; set; }
        public static Expression<Func<Entities.ClubCompetition, ClubCompGetModel>> Projection => clubcomp => new ClubCompGetModel()
        {
            CompetitionId = clubcomp.CompetitionId,
            ClubId = clubcomp.ClubId
        };

    }
}
