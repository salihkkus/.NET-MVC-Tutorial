using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje4.Models;

namespace Proje4.Controllers;

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

    public IActionResult DersListesi()
    {
        List<Ders> dersler = new List<Ders>
        {
            new Ders {Id=1,Adi="Matematik",DersResmi="matematik.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi bir hayli zor olan bir derstir."},
            new Ders {Id=2,Adi="Fizik",DersResmi="fizik.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi biraz zor olan bir derstir."},
            new Ders {Id=3,Adi="Tarih",DersResmi="tarih.jpeg",DersKisaAciklama="Sözel Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi zor olan bir derstir."},
            new Ders {Id=4,Adi="Bilgisayar Ağları",DersResmi="ag.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi hayli zor olan bir derstir."},
            new Ders {Id=5,Adi="Türkçe",DersResmi="turkce.jpeg",DersKisaAciklama="Sözel Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi kolay bir derstir."}
        };

        return View(dersler);
    }

    public IActionResult DersDetay(int id)
    {

        List<Ders> dersler = new List<Ders>
        {
            new Ders {Id=1,Adi="Matematik",DersResmi="matematik.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi bir hayli zor olan bir derstir."},
            new Ders {Id=2,Adi="Fizik",DersResmi="fizik.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi biraz zor olan bir derstir."},
            new Ders {Id=3,Adi="Tarih",DersResmi="tarih.jpeg",DersKisaAciklama="Sözel Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi zor olan bir derstir."},
            new Ders {Id=4,Adi="Bilgisayar Ağları",DersResmi="ag.jpeg",DersKisaAciklama="Sayısal Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi hayli zor olan bir derstir."},
            new Ders {Id=5,Adi="Türkçe",DersResmi="turkce.jpeg",DersKisaAciklama="Sözel Zorunlu Ders",DersAciklama="Çok zevkli olmakla beraber geçmesi kolay bir derstir."}
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
