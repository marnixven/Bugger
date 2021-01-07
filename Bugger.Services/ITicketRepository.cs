using Bugger.Models;
using System;
using System.Collections.Generic;

namespace Bugger.Services
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets();
    }
}
