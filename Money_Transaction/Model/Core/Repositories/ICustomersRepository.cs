using Money_Transaction.Model.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Model.Core.Repositories
{
    public interface ICustomersRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetAllCustomersExceptSender(Guid? CustomerId);
        Customer GetCusomerById(Guid CustomerId);
        Customer GetCusomerByIdWithTransactions(Guid CustomerId);
        int GetCustomerCount();
        bool MakeTransaction(Transaction transaction);


    }
}
