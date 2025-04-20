using BosProje_3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BosProje_3.Controllers
{
    public class DenemeController : Controller
    {
        public string Index()
        {
            return "Deneme'in Index'i";
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }

        public IActionResult Index7()
        {
            return View("Index6");
        }

        public IActionResult Index8()
        {
            string degisken = "Merhaba Index8";
            return View(degisken);
        }
        public IActionResult Index9()
        {
            string degisken = "Merhaba Index9";
            return View(model: degisken);
        }

        public IActionResult Index10()
        {
            ViewBag.Veri1 = "ViewBag Veri 1";
            ViewData["Veri2"] = "ViewData Veri 1";
            return View();
        }
        public IActionResult Index11()
        {
            return View();
        }


        public IActionResult Index12()
        {
            Katilimci katilimci1 = new()
            {
                EpostaAdresi = "a@a.com",
                KatilimDurumu = "Evet",
                Sifre = "1234"
            };
            return View(katilimci1);
        }
        [HttpGet]
        public IActionResult Index13(string EpostaAdresi, string Sifre, string KatilimDurumu)
        {

            Console.WriteLine(EpostaAdresi);
            Console.WriteLine(Sifre);
            Console.WriteLine(KatilimDurumu);

            return View();
        }

        public IActionResult Index14()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index14(string EpostaAdresi, string Sifre, string KatilimDurumu)
        {
             Console.WriteLine(EpostaAdresi);
            Console.WriteLine(Sifre);
            Console.WriteLine(KatilimDurumu);
            return View();
        }

        
    }
}