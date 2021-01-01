using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
