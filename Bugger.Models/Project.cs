using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
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
