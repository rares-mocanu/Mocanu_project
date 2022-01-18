namespace Mocanu_project.Entities
{
    public class Club
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public  string Address{ get; set; }
        public string Email { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<ClubCompetition> ClubCompetitions { get; set; }
    }
}
