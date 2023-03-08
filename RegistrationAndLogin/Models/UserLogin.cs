using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class UserLogin
    {
        [DisplayName("EmailID")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="Email ID required")]
        public string EmailID { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [DisplayName("RememberMe")]
        public bool RememberMe { get; set; }
    }
}