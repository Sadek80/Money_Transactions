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
    public class CustomerModel : PageModel
    {
        private readonly ICustomersRepository _customersRepository;

        public Customer customer { get; set; }
        public List<Transaction> AllRelatedTransactions { get; set; }
                = new List<Transaction>();

        public CustomerModel(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }
        public void OnGet(Guid customerId)
        {
            customer = _customersRepository.GetCusomerByIdWithTransactions(customerId);

            if(customer.SentTransactions.Count > 0)
                AllRelatedTransactions.AddRange(customer.SentTransactions);

            if(customer.RecievedTransactions.Count > 0)
                AllRelatedTransactions.AddRange(customer.RecievedTransactions);

            if(AllRelatedTransactions.Count > 0)
                AllRelatedTransactions = AllRelatedTransactions.OrderByDescending(t => t.Date).ToList();

        }
    }
}
