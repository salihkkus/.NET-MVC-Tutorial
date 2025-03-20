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
    public class FabrikaController : Controller
    {
        private readonly ILogger<FabrikaController> _logger;

        public FabrikaController(ILogger<FabrikaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Urun> Urunler = new List<Urun>()
            {

            new Urun()  
                { Id=1,
                UrunAdi="Izgara Köfte",
                UrunResmi="abc.jpg"
                },
            new Urun()  
                { Id=2,
                UrunAdi="Tavuk Döner",
                UrunResmi="xyz.jpg"
                },
            new Urun()  
                { Id=3,
                UrunAdi="Sütlaç",
                UrunResmi="def.jpg"
                }


            };

            return View(Urunler);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}