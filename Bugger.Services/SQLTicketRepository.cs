using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Services
{
    public class SQLTicketRepository : ITicketRepository
    {
        private readonly AppDbContext context;

        public SQLTicketRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Ticket Add(Ticket newTicket)
        {
            context.Tickets.Add(newTicket);
            context.SaveChanges();
            return newTicket;
        }

        public Ticket Delete(int id)
        {
            Ticket ticket = context.Tickets.Find(id);
            if (ticket != null)
            {
                context.Tickets.Remove(ticket);
                context.SaveChanges();
            }
            return ticket;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return context.Tickets;
        }

        public Ticket GetTicket(int id)
        {
            return context.Tickets.Find(id);
        }

        public Ticket Update(Ticket updatedTicket)
        {
            var ticket = context.Tickets.Attach(updatedTicket);
            ticket.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updatedTicket;
        }
    }
}
