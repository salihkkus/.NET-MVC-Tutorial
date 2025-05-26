using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AuthenticationAuthorization.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuthenticationAuthorization.Controllers;

public class HomeController : Controller
{
    private readonly DatabaseContext _context;

    public HomeController(DatabaseContext context)
    {
        _context = context;
    }

    [Authorize]
    public IActionResult Index()
    {

        var claims=User.Claims;
        string roladi = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
        ViewBag.RolAdi=roladi;

        return View();
    }

    public string Ekle()
    {

        string hashlipswd=HashHelper.ComputeMD5Hash("1234");

        Roles roleadmin = new Roles()
        {
            RoleNames="Admin"
        };

        Roles roleuser = new Roles()
        {
            RoleNames="User"
        };
       
        Users SerdarAdmin= new Users()
        {
            Rol=roleadmin,
            UserName="SerdarAdmin",
            PasswordHash=hashlipswd

       };
       Users SerdarUser= new Users()
        {
            Rol=roleuser,
            UserName="SerdarUser",
            PasswordHash=hashlipswd

       };

        
        _context.Add(SerdarAdmin);
      
        _context.Add(SerdarUser);

        _context.SaveChanges();

        return "başarılı";
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
          if(User.Identity!.IsAuthenticated)
            {
                return RedirectToAction("Index","Home");
            }
        return View(); // Login.cshtml
    }
    [HttpPost]
    public  async Task<IActionResult> Login(LoginViewModel model)
    {

        //if(!string.IsNullOrEmpty(model.UserName)||!string.IsNullOrEmpty(model.PasswordHash))
        if(ModelState.IsValid) 
        {

            var PasswordHashli=HashHelper.ComputeMD5Hash(model.PasswordHash);
            var UserName=model.UserName;

            var isUser = _context.Kullanicilar.FirstOrDefault(x => x.UserName == UserName
             && x.PasswordHash == PasswordHashli);
              if(isUser != null)
                {
                    var userClaims = new List<Claim>();
                    userClaims.Add(new Claim(ClaimTypes.NameIdentifier, isUser.Id.ToString()));
                    userClaims.Add(new Claim(ClaimTypes.Name, isUser.UserName ?? ""));
                    var rolu=_context.Roller.SingleOrDefault(x => x.Id == isUser.RolId);
                    var roluadi=rolu?.RoleNames.ToString();

                    //var roluAdi = _context.Roller
                    // .Where(x => x.Id == isUser.RolId)
                    // .Select(x => x.RoleNames.ToString())
                    // .SingleOrDefault();
                    userClaims.Add(new Claim(ClaimTypes.Role, roluadi?? ""));
                    
                    var claimsIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties 
                    {
                        IsPersistent = true
                    };

                  await  HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), 
                        authProperties);

                    return RedirectToAction("Index","Home");
                           
                }
                else 
                
                return View(model);
        }
        return View(model);
    }

    public async Task<IActionResult> Logout()
    {

        await HttpContext.SignOutAsync("Cookies"); // ya da varsayılan şema: CookieAuthenticationDefaults.AuthenticationScheme

        return RedirectToAction("Login", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
