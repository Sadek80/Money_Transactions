using Microsoft.EntityFrameworkCore;
using Money_Transaction.Model.Core.Domain;
using Money_Transaction.Model.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Model.Persistence
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly AppDataContext _dataContext;

        public TransactionsRepository(AppDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _dataContext.Transactions.Include(t => t.Sender).Include(t => t.Reciever).OrderByDescending(t => t.Date);
        }

        public IEnumerable<Transaction> GetRecentTransactions()
        {
            return _dataContext.Transactions.OrderByDescending(t => t.Date).Take(5);
        }

        public int GetTransactionsCount()
        {
            return _dataContext.Transactions.Count();
        }

      
    }
}
