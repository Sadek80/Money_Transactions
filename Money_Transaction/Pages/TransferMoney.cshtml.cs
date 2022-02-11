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
    public class TransferMoneyModel : PageModel
    {
        private readonly ICustomersRepository _customersRepository;

        public Customer Sender { get; set; }
        public IEnumerable<Customer> CustomersList { get; set; }

        [BindProperty]
        public Transaction Transaction { get; set; }

        public TransferMoneyModel(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }
        public void OnGet(Guid customerId)
        {
            Sender = _customersRepository.GetCusomerById(customerId);
            CustomersList = _customersRepository.GetAllCustomersExceptSender(customerId);
        }

        public async Task<IActionResult> OnPost()
        {
            Transaction.Id = Guid.NewGuid();
            Sender = _customersRepository.GetCusomerById(Transaction.SenderId);
            if(Transaction.Amount < 0)
                ModelState.AddModelError("Transaction.Amount", "Unrecognized Transaction Amount");


            if (Transaction.Amount > Sender.Balance)
            {
                ModelState.AddModelError("Transaction.Amount", "Transaction Amount Exceeds The Sender Balance");
            }

            //if (ModelState.IsValid)
            //{
            //    await _db.Category.AddAsync(Category);
            //    await _db.SaveChangesAsync();
            //    TempData["success"] = "Category created successfully";
            //    return RedirectToPage("Index");
            //}
            return Page(Sender, Transaction);
        }
    }
}
