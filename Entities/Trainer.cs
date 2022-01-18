namespace Mocanu_project.Entities
{
    public class Trainer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int StyleId { get; set; }
        public virtual Style style { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
