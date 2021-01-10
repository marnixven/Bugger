﻿using Bugger.Models;
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
                new Ticket() {TicketId = 1, TicketProject = "Other", TicketTitle = "Deletepage Userscreen",
                    TicketDescription = "Bulding a Delete page for users",
                    Status = Status.Completed, AssignedToUserId = 1, Created = DateTime.Now},

                new Ticket() {TicketId = 2, TicketProject = "Other", TicketTitle = "CRUD Pages Ticketscreen",
                    TicketDescription = "Bulding Create, Read, Update and Delete pages for tickets",
                    Status = Status.InProgress, AssignedToUserId = 1, Created = DateTime.Now},

                new Ticket() {TicketId = 3, TicketProject = "Other", TicketTitle = "SQL Server implementation",
                    TicketDescription = "Store data in a local SQL Server database instead of MockUserRepository, MockProjectRepository and MockTicketRepository",
                    Status = Status.Open, AssignedToUserId = 1, Created = DateTime.Now},

                new Ticket() {TicketId = 4, TicketProject = "Other", TicketTitle = "Remove button",
                    TicketDescription = "Remove Deletebutton from Add new user screen",
                    Status = Status.Completed, AssignedToUserId = 1, Created = DateTime.Now},

                new Ticket() {TicketId = 5, TicketProject = "Other", TicketTitle = "Prio filed",
                    TicketDescription = "Add column 'Prio' to Tickets-table",
                    Status = Status.Open, AssignedToUserId = 1, Created = DateTime.Now}
            };
        }

        public Ticket Add(Ticket newTicket)
        {
            newTicket.TicketId = _ticketList.Max(e => e.TicketId) + 1;
            _ticketList.Add(newTicket);
            return newTicket;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketList;
        }

        public Ticket GetTicket(int id)
        {
            return _ticketList.FirstOrDefault(e => e.TicketId == id);
        }

        public Ticket Update(Ticket updatedTicket)
        {
            Ticket ticket = _ticketList.FirstOrDefault(e => e.TicketId == updatedTicket.TicketId);

            if(ticket != null)
            {
                ticket.TicketId = updatedTicket.TicketId;
                ticket.TicketProject = updatedTicket.TicketProject;
                ticket.TicketTitle = updatedTicket.TicketTitle;
                ticket.TicketDescription = updatedTicket.TicketDescription;
                ticket.Status = updatedTicket.Status;
                ticket. AssignedToUserId= updatedTicket.AssignedToUserId;
                ticket.Created = updatedTicket.Created;
            }
            return ticket;

        }
    }
}
