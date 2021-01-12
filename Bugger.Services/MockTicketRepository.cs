using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bugger.Services
{
    public class MockTicketRepository : ITicketRepository
    {
        private List<Ticket> _ticketList;

        public MockTicketRepository()
        {
            _ticketList = new List<Ticket>()
            {
                new Ticket() {Id = 1, TicketProject = "Other", TicketTitle = "Deletepage Userscreen",
                    TicketDescription = "Bulding a Delete page for users",
                    Status = Status.Completed, AssignedToUser = "Marnix", Created = DateTime.Now},

                new Ticket() {Id = 2, TicketProject = "Other", TicketTitle = "CRUD Pages Ticketscreen",
                    TicketDescription = "Bulding Create, Read, Update and Delete pages for tickets",
                    Status = Status.InProgress, AssignedToUser = "Marnix", Created = DateTime.Now},

                new Ticket() {Id = 3, TicketProject = "Other", TicketTitle = "SQL Server implementation",
                    TicketDescription = "Store data in a local SQL Server database instead of MockUserRepository, MockProjectRepository and MockTicketRepository",
                    Status = Status.Open, AssignedToUser = "Marnix", Created = DateTime.Now},

                new Ticket() {Id = 4, TicketProject = "Other", TicketTitle = "Remove button",
                    TicketDescription = "Remove Deletebutton from Add new user screen",
                    Status = Status.Completed, AssignedToUser = "Marnix", Created = DateTime.Now},

                new Ticket() {Id = 5, TicketProject = "Other", TicketTitle = "Prio field",
                    TicketDescription = "Add column 'Prio' to Tickets-table",
                    Status = Status.Open, AssignedToUser = "Marnix", Created = DateTime.Now}
            };
        }

        public Ticket Add(Ticket newTicket)
        {
            newTicket.Id = _ticketList.Max(e => e.Id) + 1;
            _ticketList.Add(newTicket);
            return newTicket;
        }

        public Ticket Delete(int id)
        {
            Ticket ticketToDelete = _ticketList.FirstOrDefault(e => e.Id == id);

            if(ticketToDelete != null)
            {
                _ticketList.Remove(ticketToDelete);
            }

            return ticketToDelete;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketList;
        }

        public Ticket GetTicket(int id)
        {
            return _ticketList.FirstOrDefault(e => e.Id == id);
        }

        public Ticket Update(Ticket updatedTicket)
        {
            Ticket ticket = _ticketList.FirstOrDefault(e => e.Id == updatedTicket.Id);

            if(ticket != null)
            {
                ticket.TicketProject = updatedTicket.TicketProject;
                ticket.TicketTitle = updatedTicket.TicketTitle;
                ticket.TicketDescription = updatedTicket.TicketDescription;
                ticket.Status = updatedTicket.Status;
                ticket. AssignedToUser= updatedTicket.AssignedToUser;
                ticket.Created = updatedTicket.Created;
            }
            return ticket;
        }
    }
}
