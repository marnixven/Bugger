using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CreatedBy { get; set; }
        public string AssignedToUserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
