using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.DTO
{
    public class UserCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
