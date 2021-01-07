﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bugger.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string ToProject { get; set; }
        [Required]
        [Display(Name = "Title")]
        [MinLength(3, ErrorMessage = "Ticket title should contain at least 3 characters")]
        public string TicketTitle { get; set; }
        [Required]
        [Display(Name = "Description")]
        [MinLength(3, ErrorMessage = "Name should contain at least 3 characters")]
        public string TicketDescription { get; set; }
        [Required]
        public Status? Status { get; set; }
        [Display(Name = "Assigned to")]
        public int AssignedToUserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
