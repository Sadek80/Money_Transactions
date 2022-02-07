using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Money_Transaction.Model.Core.Domain
{
    public class Customer
    {
        [Key]
        [MaxLength(10)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        public double Balance { get; set; }

        [MaxLength(100)]
        public string ImageUrl { get; set; }

        public List<Transaction> SentTransactions { get; set; }
        public List<Transaction> RecievedTransactions { get; set; }

    }
}
