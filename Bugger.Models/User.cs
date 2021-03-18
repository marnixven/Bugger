using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Name should contain at least 2 characters")]
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Username should contain at least 3 characters")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Username should contain at least 3 characters")]
        //[Display(Name = "Password")]
        public string Password { get; set; }
        [Required]//[Required(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [Required]
        public bool isAdmin { get; set; }
        public bool isDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        [Required]
        public DateTime AddDate { get; set; }
        [Required]
        public int LastUpdateUserID { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
    }
}
