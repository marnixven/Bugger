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
    public class IndexModel : PageModel
    {
        private readonly ITicketRepository ticketRepository;

        public IEnumerable<Ticket> Tickets { get; set; }

        public IndexModel(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public void OnGet()
        {
            Tickets = ticketRepository.GetAllTickets();
        }
    }
}
