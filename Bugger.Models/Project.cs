﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime Created { get; set; }
    }
}
