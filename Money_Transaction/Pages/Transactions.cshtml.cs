using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Money_Transaction.Model.Core.Domain;
using Money_Transaction.Model.Core.Repositories;

namespace Money_Transaction.Pages
{
    public class TransactionsModel : PageModel
    {
        private readonly ITransactionsRepository _transactionsRepository;

        public int NumOfTransactions { get; set; }
        public IEnumerable<Transaction> Transactions{ get; set; }

        public TransactionsModel(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }
        public void OnGet()
        {
            NumOfTransactions = _transactionsRepository.GetTransactionsCount();
            Transactions = _transactionsRepository.GetAllTransactions();
        }
    }
}
