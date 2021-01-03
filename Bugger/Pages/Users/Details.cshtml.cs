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
    public class DetailsModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public DetailsModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User SingleUser { get; private set; }

        public void OnGet(int id)
        {
            SingleUser = userRepository.GetUser(id);
        }
    }
}
