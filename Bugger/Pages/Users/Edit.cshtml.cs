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
    public class EditModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public EditModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User SingleUser { get; set; }

        public IActionResult OnGet(int id)
        {
            SingleUser = userRepository.GetUser(id);

            if (SingleUser == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
        public IActionResult OnPost(User SingleUser)
        {
            SingleUser = userRepository.Update(SingleUser);
            return RedirectToPage("Index");
        }
    }
}
