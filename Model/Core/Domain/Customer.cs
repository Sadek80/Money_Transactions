using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Transaction.Model.Core.Domain
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        public double Balance { get; set; }

        [MaxLength(100)]
        public string ImageUrl { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        public List<Transaction> SentTransactions { get; set; }
        public List<Transaction> RecievedTransactions { get; set; }

    }
}
