using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace MVC_BudgetApplication_Final.Controllers;

public class HomeController : Controller
{
    //The logger method, return view method, and return error page were removed from the scaffold.

    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
}

