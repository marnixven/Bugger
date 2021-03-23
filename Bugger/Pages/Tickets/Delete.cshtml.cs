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
    public class DeleteModel : PageModel
    {
        private readonly ITicketRepository ticketRepository;

        public DeleteModel(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        [BindProperty]
        public Ticket SingleTicket { get; set; }
        public ITicketRepository TicketRepository { get; }

        public IActionResult OnGet(int id)
        {
            SingleTicket = ticketRepository.GetTicket(id);

            if (SingleTicket == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            Ticket ticketToDelete = ticketRepository.Delete(SingleTicket.ID);

            if (ticketToDelete == null)
            {
                return RedirectToPage("/NotFound");
            }

            return RedirectToPage("/Tickets/Index");
        }
    }
}