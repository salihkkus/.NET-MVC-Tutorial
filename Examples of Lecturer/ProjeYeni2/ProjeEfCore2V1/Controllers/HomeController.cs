using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjeEfCore2.Models;

namespace ProjeEfCore2.Controllers;

public class HomeController : Controller
{



    public IActionResult Index()
    {
        
        using (var context= new SchoolContext())
        {
    //creates db if not exists 
    context.Database.EnsureCreated();

    //create entity objects
    var grd1 = new Grade() { GradeName = "1st Grade" };
    var std1 = new Student() {  FirstName = "Yash", LastName = "Malhotra", Grade = grd1};

    //add entitiy to the context
    context.Students.Add(std1);

    //save data to the database tables
    context.SaveChanges();

    //retrieve all the students from the database
    foreach (var s in context.Students) {
        Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
    }
}
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
