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
    public class KutuphaneController : Controller
    {
        private readonly ILogger<KutuphaneController> _logger;

        public KutuphaneController(ILogger<KutuphaneController> logger)
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

        public IActionResult Kitaplar()
        {
            List<Kitap> kitaplar = new List<Kitap>()
            {
                new Kitap()
                {
                    Id=1,
                    Adi="Matematik",
                    KitapResmi="matematik.jpg"
                },
                new Kitap()
                {
                    Id=2,
                    Adi="Sosyal Bilgiler",
                    KitapResmi="sosyal.jpg"
                },
                new Kitap()
                {
                    Id=3,Adi="Fizik",
                    KitapResmi="fizik.jpg"

                }
            };
            return View(kitaplar);
        }

        public IActionResult KitapGetir()
        {
            Kitap tarihkitabi = new Kitap()
            {
                Id = 1,
                Adi = "İnklap Tarihi",
                KitapResmi = ""
            };

            Kitap matematikkitabi = new Kitap()
            {
                Id = 2,
                KitapResmi = null,
                Adi = "Matematik"
            };

            return View(matematikkitabi);

        }

    }
}