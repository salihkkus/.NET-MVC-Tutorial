using Microsoft.AspNetCore.Mvc;
using Proje1.Models;

namespace Proje1.Controllers;

public class KutuphaneController : Controller
{

    public IActionResult Error()
    {

        return View("Error");
    }

    public IActionResult Kitaplar()
    {
        List<Kitap> kitaplar = new List<Kitap>(){
            new Kitap(){
                Id=1,
                Adi="Matematik",
                KitapResmi="matematik.jpg"
            },
            new Kitap(){
                Id=2,
                Adi="Sosyal",
                KitapResmi="sosyal.jpg"
            },
            new Kitap(){
                Id=3,
                Adi="Tarih",
                KitapResmi="tarih.jpg"

            }
        };
        return View(kitaplar);
    }

    public IActionResult KitapGetir()
    {

        Kitap tarihKitabi = new Kitap()
        {
            Id = 1,
            Adi = "İnkilap Tarihi",
            KitapResmi = ""
        };

        return View(tarihKitabi);
    }


}