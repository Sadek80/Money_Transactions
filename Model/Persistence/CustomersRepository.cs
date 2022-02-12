using Microsoft.EntityFrameworkCore;
using Money_Transaction.Model.Core.Domain;
using Money_Transaction.Model.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Model.Persistence
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly AppDataContext _dataContext;

        public CustomersRepository(AppDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dataContext.Customers;
        }

        public IEnumerable<Customer> GetAllCustomersExceptSender(Guid? CustomerId)
        {
            if (CustomerId == Guid.Empty)
            {
                return _dataContext.Customers;
            }

            return _dataContext.Customers.Where(c => c.Id != CustomerId);
        }

        public Customer GetCusomerByIdWithTransactions(Guid CustomerId)
        {
            if (CustomerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(CustomerId));
            }
            return _dataContext.Customers
                               .Include(c => c.SentTransactions)
                               .ThenInclude(t => t.Reciever)
                               .Include(c => c.RecievedTransactions)
                               .ThenInclude(t => t.Sender)
                               .FirstOrDefault(c => c.Id == CustomerId);
        }

        public Customer GetCusomerById(Guid CustomerId)
        {
            if (CustomerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(CustomerId));
            }

            return _dataContext.Customers.FirstOrDefault(c => c.Id == CustomerId);
        }

        public int GetCustomerCount()
        {
            return _dataContext.Customers.Count();
        }

        public bool MakeTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            transaction.Id = Guid.NewGuid();
            transaction.Date = DateTimeOffset.Now;

            var reciever = GetCusomerById(transaction.RecieverId);
            var sender = GetCusomerById(transaction.SenderId);

            if (transaction.Type == TransactionType.Express)
            {
               
                reciever.Balance += transaction.Amount - 1.50;
            }
            else
            {
                reciever.Balance += transaction.Amount - 0.99;
            }

            sender.Balance -= transaction.Amount; 

            _dataContext.Transactions.Add(transaction);

            return (_dataContext.SaveChanges() >= 0);
        }
    }
}
