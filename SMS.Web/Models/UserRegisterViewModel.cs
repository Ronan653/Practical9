using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SMS.Data.Models;

namespace SMS.Web.Models
{
    // need separate registerview model for register remote validation which is not needed in login
    public class UserRegisterViewModel
    {       
        [Required]
        public string Name { get; set; }

        [EmailAddress][Required]
        public string Email { get; set; }

        [Required]
        public String Password { get; set; }

        [Required][Compare("Password", ErrorMessage = "Passwords do not Match")]
        public string PasswordConfirm { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}