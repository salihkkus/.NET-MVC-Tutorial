using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje3.Models;

namespace Proje3.Controllers;

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

    public IActionResult Dersler()
    {
        List<Ders> dersler = new List<Ders>()
        {
            new Ders(){Id=1,DersAdi="Fizik",DersResim="Fizik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Zor Geçilen Bir Ders Olabilir"},
            new Ders(){Id=2,DersAdi="Matematik",DersResim="Matematik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Çok Zor Geçilen Bir Ders Olabilir"},
            new Ders(){Id=3,DersAdi="Tarih",DersResim="Tarih.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklama="Ünide Normal Geçilen Bir Ders Olabilir"},
            new Ders(){Id=4,DersAdi="Türkçe",DersResim="Turkce.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklama="Ünide Normal Geçilen Bir Ders Olabilir"},
            new Ders(){Id=5,DersAdi="Bilgisayar Ağları",DersResim="Ag.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Zor Geçilen Bir Ders Olabilir"}
        };


        return View(dersler);
    }

    public IActionResult DersDetay(int id)
    {
        List<Ders> dersler = new List<Ders>()
        {
            new Ders(){Id=1,DersAdi="Fizik",DersResim="Fizik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Zor Geçilen Bir Ders Olabilir"},
            new Ders(){Id=2,DersAdi="Matematik",DersResim="Matematik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Çok Zor Geçilen Bir Ders Olabilir"},
            new Ders(){Id=3,DersAdi="Tarih",DersResim="Tarih.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklama="Ünide Normal Geçilen Bir Ders Olabilir"},
            new Ders(){Id=4,DersAdi="Türkçe",DersResim="Turkce.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklama="Ünide Normal Geçilen Bir Ders Olabilir"},
            new Ders(){Id=5,DersAdi="Bilgisayar Ağları",DersResim="Ag.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklama="Ünide Zor Geçilen Bir Ders Olabilir"}
        };

        Ders? ders = dersler.FirstOrDefault(x => x.Id == id);

        return View(ders);

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
