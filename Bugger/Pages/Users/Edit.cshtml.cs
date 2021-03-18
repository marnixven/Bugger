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

        public IActionResult OnGet(int? id)
            
        {
            if (id.HasValue)
            {
                SingleUser = userRepository.GetUser(id.Value);
            }
            else
            {
                SingleUser = new User();
            }

            if (SingleUser == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
        public IActionResult OnPost(User SingleUser)
        {
            if (ModelState.IsValid)
            {
                if (SingleUser.UserId > 0)
                {
                    SingleUser = userRepository.Update(SingleUser);
                }
                else
                {
                    SingleUser = userRepository.Add(SingleUser);
                }
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
