using Money_Transaction.Model.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Model.Core.Repositories
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transaction> GetAllTransactions();
        IEnumerable<Transaction> GetRecentTransactions();
        bool MakeTransaction(Transaction transaction, Guid senderId, Guid recieverId);
        int GetTransactionsCount();
    }
}
