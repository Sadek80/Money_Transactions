using Microsoft.EntityFrameworkCore;
using Money_Transaction.Model.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Model
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Sender)
                .WithMany(c => c.SentTransactions)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Reciever)
                .WithMany(c => c.RecievedTransactions)
                .IsRequired();            
        }
    }
}
