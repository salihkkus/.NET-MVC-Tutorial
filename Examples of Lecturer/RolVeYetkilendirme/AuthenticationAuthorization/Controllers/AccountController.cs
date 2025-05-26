using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AuthenticationAuthorization.Controllers
{
    public class AccountController : Controller
{
    [AllowAnonymous]
    public IActionResult AccessDenied()
    {
        return View();
    }
}
}