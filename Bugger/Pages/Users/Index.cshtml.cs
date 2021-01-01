using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugger.Models;
using Bugger.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bugger.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public IEnumerable<User> Users { get; set; }

        public IndexModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
        public void OnGet()
        {
            Users = userRepository.GetAllUsers();
        }
    }
}
