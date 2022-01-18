using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mocanu_project.Entities;

namespace Mocanu_project.Entity_Config
{
    public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(a => a.Name)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);
        }
    }
}
