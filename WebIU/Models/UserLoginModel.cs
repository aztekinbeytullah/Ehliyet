
using System.ComponentModel.DataAnnotations;

namespace WebIU.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz.")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string?  Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}
