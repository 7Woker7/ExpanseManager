using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.DTO_s
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
