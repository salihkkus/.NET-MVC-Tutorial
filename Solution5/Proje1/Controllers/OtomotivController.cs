using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje1.Models;

namespace Proje1.Controllers
{
    //[Route("[controller]")]
    public class OtomotivController : Controller
    {
        private readonly ILogger<OtomotivController> _logger;

        public OtomotivController(ILogger<OtomotivController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Araba> arabalar = new List<Araba>()
            {
new Araba(){
Id=1,Adi="Seul",Resimid="1.jpg"
}, new Araba()
{
    Id=2,Adi="Golf",Resimid="2.jpg"

}, new Araba()
{
Id=3,Adi="Civic",Resimid="3.jpg"
}


            };

            return View(arabalar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}