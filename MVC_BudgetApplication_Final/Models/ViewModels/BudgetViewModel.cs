using System;
using MVC_BudgetApplication_Final.Models.ViewModels;

namespace MVC_BudgetApplication_Final.Models.VeiwModels
{
	public class BudgetViewModel
	{
        public List<Transaction>? Transactions { get; set; }
        public InsertTransactionViewModel InsertTransaction { get; set; }
    }
}

