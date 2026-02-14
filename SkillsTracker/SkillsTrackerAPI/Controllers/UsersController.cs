using Microsoft.AspNetCore.Mvc;
using SkillsTrackerAPI.Data;
using SkillsTrackerAPI.Models.DTOs;
using SkillsTrackerAPI.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace SkillsTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private readonly SkillsTrackerDbContext _context;

        public UsersController(SkillsTrackerDbContext context)
        {
            _context = context;
        }   
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users
                        .Select(x => new UserReadDto
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Email = x.Email,
                            CreatedAt = x.CreatedAt,
                        })
                        .ToList();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var users = _context.Users.Find(id);

            if (users == null) 
                return NotFound();

            var dto = new UserReadDto
            {
                Id = id,
                Name = users.Name,
                Email = users.Email,
                CreatedAt = users.CreatedAt,
            };

            return Ok(dto);

        }
        [HttpPost]
        public IActionResult Create(UserCreateDto dto)
        {
            var user = new User
            {
                Name = dto.UserName,
                Email = dto.Email,
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
