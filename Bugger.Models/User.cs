using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Verplicht veldje!")]
        public string FullName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Your Username should contain at least 3 characters")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
            ErrorMessage = "Invalid Email Format")]
        [Display(Name ="Mijn email adres")]
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
