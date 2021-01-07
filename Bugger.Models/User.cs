using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Name should contain at least 2 characters")]
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Username should contain at least 3 characters")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]//[Required(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
