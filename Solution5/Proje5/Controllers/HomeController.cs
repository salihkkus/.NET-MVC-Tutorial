using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje5.Models;

namespace Proje5.Controllers;

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
        List<Ders> dersler1 = new List<Ders>()
        {
            new Ders(){Id=1,Adi="Matematik",DersResmi="matematik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"},
            new Ders(){Id=2,Adi="Fizik",DersResmi="fizik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"}
        };

        List<Ders> dersler2 = new()
        {
            new(){Id=1,Adi="Matematik",DersResmi="matematik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"},
            new(){Id=2,Adi="Fizik",DersResmi="fizik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"},
            new(){Id=3,Adi="Turkce",DersResmi="turkce.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklamasi="Çok Zevkli Gönüllere Hitap Eden Bir Ders"},
            new(){Id=4,Adi="Tarih",DersResmi="tarih.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklamasi="Çok Zevkli Ama Yanlış Kaynaklar Olabilir Dikkat Etmek Lazım"},
            new(){Id=5,Adi="Bilgisayar Ağları",DersResmi="ag.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama İşin Özünü Bilmezsen İlerleyemezsin"}
        };


        return View(dersler2);
    }

    public IActionResult DersDetay(int id)
    {
         List<Ders> dersler2 = new()
        {
            new(){Id=1,Adi="Matematik",DersResmi="matematik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"},
            new(){Id=2,Adi="Fizik",DersResmi="fizik.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama Geçmesi ve Anlaması Bir O Kadar Zor"},
            new(){Id=3,Adi="Turkce",DersResmi="turkce.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklamasi="Çok Zevkli Gönüllere Hitap Eden Bir Ders"},
            new(){Id=4,Adi="Tarih",DersResmi="tarih.jpeg",DersKisaAciklama="Sözel Bir Ders",DersAciklamasi="Çok Zevkli Ama Yanlış Kaynaklar Olabilir Dikkat Etmek Lazım"},
            new(){Id=5,Adi="Bilgisayar Ağları",DersResmi="ag.jpeg",DersKisaAciklama="Sayısal Bir Ders",DersAciklamasi="Çok Zevkli Ama İşin Özünü Bilmezsen İlerleyemezsin"}
        };
        Ders? ders=dersler2.FirstOrDefault(x=>x.Id==id);

        return View(ders);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
