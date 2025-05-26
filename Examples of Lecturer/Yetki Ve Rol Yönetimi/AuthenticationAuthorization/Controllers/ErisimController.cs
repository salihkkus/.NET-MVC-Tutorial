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
    
    public class ErisimController : Controller
    {
        public string HerkeseAcik()
        {
            return "Herkes Açık Erişim";
        }


        [Authorize(Roles ="Admin")]

        public string AdimAction()
        {

            return "Sadece Admin";
        }

        [Authorize(Roles ="User")]

        public string UserAction()
        {

            return "Sadece User";
        }

        [Authorize(Roles ="User, Admin")]

        public string HibritAction()
        {

            return "Hem Admin Hem User";
        }

         [Authorize]
         public string GirisYapanlar()
         {

            return "Giriş Yapan Herkes";
         }
        
    }
}