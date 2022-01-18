namespace Mocanu_project.Entities
{
    public class ClubCompetition
    {
        public int Id { get; set; }
        public int CompetitionId {  get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
        
        public virtual Competition Competition { get; set; }

    }
}
