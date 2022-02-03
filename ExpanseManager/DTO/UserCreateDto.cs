using System;
using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.DTO
{
    public record UserCreateDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        [Required, Range(1900, 2030)]
        public int Year { get; set; }
        [Required, Range(1, 12)]
        public int Month { get; set; }
        [Required, Range(1, 31)]
        public int Day { get; set; }


    }
}
