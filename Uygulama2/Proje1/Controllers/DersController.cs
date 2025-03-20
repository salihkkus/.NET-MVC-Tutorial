
using Microsoft.AspNetCore.Mvc;

namespace Proje1.Controllers;

public class DersController : Controller
{
    public DersController()
    {
    }


    public string dersEkle(){

        return "Ders eklendi";
    }

    public string dersSil(){

        return "Ders silindi";
    }

    public string index(){

        return "Öğrenci sayfası";
    }

    public IActionResult Guncelle(){
        
        return View();
    }

    // get post request farkı
}