using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Money_Transaction.Model.Core.Domain;
using Money_Transaction.Model.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICustomersRepository _customersRepository;
        private readonly ITransactionsRepository _transactionsRepository;

        public int NumOfCustomers { get; set; }
        public int NumOfTransactions { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

        public IndexModel(ICustomersRepository customersRepository, ITransactionsRepository transactionsRepository)
        {
            _customersRepository = customersRepository;
            _transactionsRepository = transactionsRepository;
        }

        public void OnGet()
        {
            NumOfCustomers = _customersRepository.GetCustomerCount();
            Customers = _customersRepository.GetAllCustomers();
            Transactions = _transactionsRepository.GetRecentTransactions();
            NumOfTransactions = _transactionsRepository.GetTransactionsCount();

        }
    }
}
