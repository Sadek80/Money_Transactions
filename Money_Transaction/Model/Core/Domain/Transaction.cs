using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Transaction.Model.Core.Domain
{
    [Index(nameof(SenderId))]
    [Index(nameof(RecieverId))]
    public class Transaction
    {
        [Key]
        //[MaxLength(10)]
        public Guid Id { get; set; }

        [ForeignKey("SenderId")]
        public Customer Sender { get; set; }

        [ForeignKey("RecieverId")]
        public Customer Reciever { get; set; }

        [Required]
        public Guid SenderId { get; set; }

        [Required(ErrorMessage = "You should choose a reciever first")]
        public Guid RecieverId { get; set; }

        public double Amount { get; set; }

        public TransactionType Type { get; set; }

        public DateTimeOffset Date { get; set; }

    }
}