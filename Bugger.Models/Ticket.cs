using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public Status? Status { get; set; }
        public string CreatedBy { get; set; }
        public int AssignedToUserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
