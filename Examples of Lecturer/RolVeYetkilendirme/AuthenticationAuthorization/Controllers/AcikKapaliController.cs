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
    [Route("[controller]")]
    [Authorize]
    public class AcikKapaliController : Controller
    {

        [HttpGet("Index")]
        [AllowAnonymous]
        public string Acik()
        {
            return "AcıkKapali Acik";
        }
        
        [HttpGet("Kapali")]
        public string Kapali()
        {
            return "AcıkKapali Kapali";
        }


    }
}