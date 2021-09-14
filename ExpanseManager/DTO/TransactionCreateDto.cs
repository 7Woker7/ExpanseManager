using System;
using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.DTO
{
    public class TransactionCreateDto
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }
        
        [Required]
        public int UserId { get; set; }
    }
}
