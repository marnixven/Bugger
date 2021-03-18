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
    public class DeleteModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public DeleteModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
        [BindProperty]
        public User SingleUser { get; set; }
        public IUserRepository UserRepository { get; }

        public IActionResult OnGet(int id)
        {
            SingleUser = userRepository.GetUser(id);

            if (SingleUser == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            User deletedUser = userRepository.Delete(SingleUser.UserId);

            if (deletedUser == null)
            {
                return RedirectToPage("/NotFound");
            }

            return RedirectToPage("/Users/Index");
        }
    }
}
