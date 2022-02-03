using System;
using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.Models
{
    public record User
    {
        //[Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        //[Required]
        public DateTime BirthDate { get; set; }

    }
}
