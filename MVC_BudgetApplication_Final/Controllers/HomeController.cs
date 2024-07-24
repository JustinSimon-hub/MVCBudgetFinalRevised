using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using MVC_BudgetApplication_Final.Models;
using MVC_BudgetApplication_Final.Models.VeiwModels;
using MVC_BudgetApplication_Final.Models.ViewModels;
using MVC_BudgetApplication_Final.Repositories;

namespace MVC_BudgetApplication_Final.Controllers;

public class HomeController : Controller
{
    //The logger method, return view method, and return error page were removed from the scaffold.

    private readonly IBudgetRepository _budgetRepository;

    public HomeController(IBudgetRepository budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }

    public IActionResult Index()
    {
        var transactions = _budgetRepository.GetTransactions();

        var viewModel = new BudgetViewModel
        {
            Transactions = transactions
        };

        return View(viewModel);


    }
}
