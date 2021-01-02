using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Services
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _UserList;

        public MockUserRepository()
        {
            _UserList = new List<User>()
            {
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 2, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 2, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 2, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 2, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
            };

        }
        public IEnumerable<User> GetAllUsers()
        {
            return _UserList;
        }
    }
}
