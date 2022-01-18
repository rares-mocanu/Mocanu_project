using Microsoft.EntityFrameworkCore;
using Mocanu_project.Entities;
using Mocanu_project.Entity_Config;
using System;

namespace Mocanu_project
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<ClubCompetition> ClubCompetitions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TrainerConfiguration());
        }

    }
}
