using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }
        public string TicketProject { get; set; }
        [MinLength(2, ErrorMessage = "Ticket title should contain at least 2 characters")]
        public string TicketTitle { get; set; }
        [MinLength(3, ErrorMessage = "Ticket description should contain at least 3 characters")]
        public string TicketDescription { get; set; }
        public Status? Status { get; set; }
        public string AssignedToUser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime AddDate { get; set; }
        public int? LastUpdateUserID { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
