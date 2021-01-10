using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugger.Models;
using Bugger.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bugger.Pages.Tickets
{
    public class EditModel : PageModel
    {
        private readonly ITicketRepository ticketRepository;

        public EditModel(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public Ticket SingleTicket { get; set; }

        //public IActionResult OnGet(int? id)

        //{
        //    if (id.HasValue)
        //    {
        //        SingleTicket = ticketRepository.GetTicket(id.Value);
        //    }
        //    else
        //    {
        //        SingleTicket = new Ticket();
        //    }

        //    if (SingleTicket == null)
        //    {
        //        return RedirectToPage("/NotFound");
        //    }

        //    return Page();
        //}
        public IActionResult OnPost(Ticket SingleTicket)
        {
            if (ModelState.IsValid)
            {
                if (SingleTicket.TicketId > 0)
                {
                    SingleTicket = ticketRepository.Update(SingleTicket);
                }
                else
                {
                    SingleTicket = ticketRepository.Add(SingleTicket);
                }
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}