using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAuthorization.Models
{
  public class LoginViewModel
    {
        [Required]
        
        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set;}

        [Required]  
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string? PasswordHash { get; set; }
    }
}