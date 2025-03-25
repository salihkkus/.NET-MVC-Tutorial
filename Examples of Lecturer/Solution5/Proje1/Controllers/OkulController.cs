using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje1.Models;


namespace Proje1.Controllers
{
    public class OkulController : Controller
    {

        public string index()
        {
            return "Okula Hoşgeldin";

        }
        public string Sinif()
        {
            return "Sınıfa Hoşgeldiniz";

        }
        public IActionResult Mudur()
        {
            return View();
        }

        public IActionResult MudurY()
        {
            return View("Mudur");

        }
        public IActionResult OgrKayit()
        {

            Ogrenci ogr1 = new Ogrenci()
            {
                Id = 1,
                Adi = "Serdar"
            };

            return View(ogr1);
        }

        public IActionResult OgrListe()
        {
            List<Ogrenci> ogrListe = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Id=1,
                    Adi="Serdar"
                },
                new Ogrenci()
                {
                    Id=2,
                    Adi="Ahmet"

                },
                new Ogrenci()
                {
                    Id=3,
                    Adi="Mehmet"

                }

            };

            return View(ogrListe);
        }

    }
}