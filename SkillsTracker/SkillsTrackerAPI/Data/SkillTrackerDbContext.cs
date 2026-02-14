using Microsoft.EntityFrameworkCore;
using SkillsTrackerAPI.Models.Entities;


namespace SkillsTrackerAPI.Data
{
    public class SkillsTrackerDbContext : DbContext
    {
        public SkillsTrackerDbContext(DbContextOptions<SkillsTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillProgress> SkillProgress { get; set; }
    }
}
