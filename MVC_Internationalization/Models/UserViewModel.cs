using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Internationalization.Models
{
    public class UserViewModel
    {
        [Display(Name = "Username", ResourceType = typeof(English))]
        [Required(ErrorMessageResourceName = "UsernameRequired", ErrorMessageResourceType = typeof(English))]
        public string Username { get; set; }

        [Display(Name = "Name", ResourceType = typeof(English))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(English))]
        public string Name { get; set; }

        [Display(Name = "Password", ResourceType = typeof(English))]
        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(English))]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword", ResourceType = typeof(English))]
        [Required(ErrorMessageResourceName = "ConfirmPasswordRequired", ErrorMessageResourceType = typeof(English))]
        [Compare("Password", ErrorMessageResourceName = "ConfirmPasswordCompare", ErrorMessageResourceType = typeof(English))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Address", ResourceType = typeof(English))]
        [Required(ErrorMessageResourceName = "AddressRequired", ErrorMessageResourceType = typeof(English))]
        public string Address { get; set; }
    }
}