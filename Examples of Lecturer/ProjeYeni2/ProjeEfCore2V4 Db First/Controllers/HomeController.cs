using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjeEfCore2.Models;

namespace ProjeEfCore2.Controllers;

public class HomeController : Controller
{
    private readonly VeritabaniContext _context;
    public HomeController(VeritabaniContext context)
    {
        _context = context;
        
    }

 
public IActionResult Index()
    {
        
        var ogrler=_context.Students.ToList();
        foreach (var item in ogrler)
        {
            System.Console.WriteLine(item.FirstName);
            
        }
        return View();
    }

    public IActionResult Privacy()
    {
        VeritabaniContext dbcontext= new();
        var ogrler= dbcontext.Students.ToList();
        foreach (var item in ogrler)
        {
            
            System.Console.WriteLine(item.LastName);
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
