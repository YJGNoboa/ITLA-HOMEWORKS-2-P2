using System.ComponentModel.DataAnnotations;

namespace SkillsTrackerAPI.Models.Entities
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public List<SkillProgress> SkillProgresses { get; set; } = new();
    }
}
        
    

        
    



