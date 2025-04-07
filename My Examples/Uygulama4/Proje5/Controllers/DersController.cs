using Microsoft.AspNetCore.Mvc;
using Proje5.Models;

namespace Proje5.Controllers;

public class DersController : Controller {

    public IActionResult DersListesi(){

        List<Ders> dersler = StatikVeritabani.DersleriGetir();

        return View(dersler);
    }

    public IActionResult DersDetay(int id){

        Ders? ders = StatikVeritabani.IdyeGoreGetir(id);

        return View(ders);
    }

    public IActionResult Ekle(){

        Ders ders = new Ders(){
                Adi="Tarih",
                Id=4,
                DersResmi="tarih.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Tarih dersi."
        };
    StatikVeritabani.Ekle(ders);

        return Redirect("~/Ders/DersListesi");
    }

    public IActionResult DersSil(int id){

        Ders? silinecek = StatikVeritabani.IdyeGoreGetir(id);
        StatikVeritabani.Sil(silinecek);
        return RedirectToAction("DersListesi", "Ders");
    }
}
