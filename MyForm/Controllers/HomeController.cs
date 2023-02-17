using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyForm.Models;

namespace MyForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Janak()
    {
        return View();
    }
     public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(Register model){
        if(ModelState.IsValid){

        }
        TempData["Message"]="record daved successfully";
        model=new Register();
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
