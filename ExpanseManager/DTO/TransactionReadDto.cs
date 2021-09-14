using ExpanseManager.Models;
using System;

namespace ExpanseManager.DTO
{
    public class TransactionReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
    }
}
