﻿using Money_Transaction.Model.Core.Domain;
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
            return _dataContext.Transactions;
        }

        public IEnumerable<Transaction> GetRecentTransactions()
        {
            return _dataContext.Transactions.OrderByDescending(t => t.Date).Take(5);
        }

        public bool MakeTransaction(Transaction transaction, Guid senderId, Guid recieverId)
        {
            if (senderId == Guid.Empty)
                throw new ArgumentNullException(nameof(senderId));

            if (recieverId == Guid.Empty)
                throw new ArgumentNullException(nameof(recieverId));

            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            transaction.SenderId = senderId;
            transaction.RecieverId = recieverId;

            _dataContext.Transactions.Add(transaction);
            _dataContext.SaveChanges();

            return (_dataContext.SaveChanges() >= 0);
        }
    }
}
