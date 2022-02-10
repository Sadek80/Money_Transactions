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
                               .Include(c => c.RecievedTransactions)
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
    }
}
