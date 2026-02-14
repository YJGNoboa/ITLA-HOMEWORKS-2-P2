
using System.ComponentModel.DataAnnotations;

namespace SkillsTrackerAPI.Models.Entities
{
    public class SkillProgress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;

        [Range(1, 100)]
        public int Level { get; set; }

        public int ExperiencePoints { get; set; }

        public DateTime ProgressDate { get; set; } = DateTime.Now;

        [MaxLength(250)]
        public string? Notes { get; set; }
    }
}





