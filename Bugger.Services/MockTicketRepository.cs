using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Services
{
    public class MockTicketRepository : ITicketRepository
    {
        private List<Ticket> _TicketList;

        public MockTicketRepository()
        {
            _TicketList = new List<Ticket>()
            {
                new Ticket() {TicketId = 1, ToProject = "Other", TicketTitle = "CRUD Pages Ticketscreen",
                    TicketDescription = "Bulding Create, Read, Update and Delete pages for tickets",
                    Status = Status.Open, AssignedToUserId = 1, CreatedBy ="Marnix", Created = DateTime.Now},

                new Ticket() {TicketId = 2, ToProject = "Other", TicketTitle = "SQL Server implementation",
                    TicketDescription = "Store data in a local SQL Server database instead of MockUserRepository, MockProjectRepository and MockTicketRepository",
                    Status = Status.Open, AssignedToUserId = 1, CreatedBy ="Marnix", Created = DateTime.Now}
            };
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _TicketList;
        }
    }
}
