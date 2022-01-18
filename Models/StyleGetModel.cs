using System.Linq.Expressions;

namespace Mocanu_project.Models
{
    public class StyleGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public static Expression<Func<Entities.Style, StyleGetModel>> Projection => style => new StyleGetModel()
        {
            Id = style.Id,
            Name = style.Name,
            Type = style.Type,
            Description = style.Description
        };


    }
}
