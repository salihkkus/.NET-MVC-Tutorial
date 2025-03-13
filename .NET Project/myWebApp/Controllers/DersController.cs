using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace myWebApp.Controllers;

public class DersController : Controller
{
    public DersController()
    {

    }
    public string dersEkle()
    {
      return "Ders Eklendi";
    }
    public string dersSil()
    {
      return "Ders Silindi";
    }
    public IActionResult Guncelle()
    {
        return View();
    }
     public string Index()
    {
        return "Öğrenci Sayfası";
    }
}