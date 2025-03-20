using Microsoft.AspNetCore.Mvc;

namespace Proje1.Controllers
{
public class DersController : Controller
{

public IActionResult Index()
{

    return View("../Home/Index");
}

}

}

