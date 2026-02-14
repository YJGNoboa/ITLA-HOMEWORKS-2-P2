using System.ComponentModel.DataAnnotations;

namespace SkillsTrackerAPI.Models.DTOs
{
    public class UserCreateDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;                              
    }
}
