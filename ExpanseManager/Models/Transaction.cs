using System;
using System.ComponentModel.DataAnnotations;

namespace ExpanseManager.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[Required]
        //public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }

        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
