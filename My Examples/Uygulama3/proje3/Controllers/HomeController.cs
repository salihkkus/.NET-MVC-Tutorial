using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using proje3.Models;

namespace proje3.Controllers;

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

    public IActionResult DersListesi(){

        List<Ders> dersler = new List<Ders>(){

            new Ders(){
                Adi="Matematik",
                Id=1,
                DersResmi="matematik.jpeg",
                DersKisaAciklama="Sayısal",
                DersAciklamasi="Matematik, evrenin çalışma düzeni ve mantığıdır."

            },
            new Ders(){
                Adi="Türkçe",
                Id=2,
                DersResmi="turkce.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bu ders türk dilinin anlaşılmasını ve öğrenmesini hedefler."
            },
            new Ders(){
                Adi="Teknoloji Tasarım",
                Id=3,
                DersResmi="teknoloji.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bilgisayar anlatır."
            },
            new Ders(){
                Adi="Tarih",
                Id=4,
                DersResmi="tarih.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Tarih dersi."
            }
        };

        return View(dersler);
    }

    public IActionResult DersDetay(int id){

        List<Ders> dersler = new List<Ders>(){

            new Ders(){
                Adi="Matematik",
                Id=1,
                DersResmi="matematik.jpeg",
                DersKisaAciklama="Sayısal",
                DersAciklamasi="Matematik, evrenin çalışma düzeni ve mantığıdır."

            },
            new Ders(){
                Adi="Türkçe",
                Id=2,
                DersResmi="turkce.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bu ders türk dilinin anlaşılmasını ve öğrenmesini hedefler."
            },
            new Ders(){
                Adi="Teknoloji Tasarım",
                Id=3,
                DersResmi="teknoloji.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bilgisayar anlatır."
            },
            new Ders(){
                Adi="Tarih",
                Id=4,
                DersResmi="tarih.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Tarih dersi."
            }
        };
        Ders ders=dersler.FirstOrDefault(x=>x.Id==id);
        

        return View(ders);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
