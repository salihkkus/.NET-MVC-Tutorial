using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje2.Models;

namespace Proje2.Controllers
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        public IActionResult UrunGetir()
        {
            Urun lastik = new Urun()
            {
                Id = 1,
                Adi = "Lassa",
                ResimYolu = null
            };

            return View(lastik);
        }

        public IActionResult Urunler()
        {
            List<Urun> products = new List<Urun>()
            {
                new Urun()
                {
                    Id = 1,
                    Adi = "Lassa",
                    ResimYolu = "lassa.jpg"
                },
                new Urun()
                {
                    Id = 2,
                    Adi = "Continental",
                    ResimYolu = "continental.jpg"
                },
                new Urun()
                {
                    Id = 3,
                    Adi = "Petlas",
                    ResimYolu = "petlas.jpg"
                }

            };



            return View(products);
        }
    }
}