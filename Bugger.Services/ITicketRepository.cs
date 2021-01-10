using Bugger.Models;
using System;
using System.Collections.Generic;

namespace Bugger.Services
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicket(int id);
        Ticket Update(Ticket updatedTicket);
        Ticket Add(Ticket newTicket);
    }
}
