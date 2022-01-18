namespace Mocanu_project.Entities
{
    public class Competition
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Prize { get; set; }
        public string Date { get; set; }
        public virtual ICollection<ClubCompetition> Clubs { get; set; }
    }
}
