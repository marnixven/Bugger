﻿using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bugger.Services
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;

        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() {Id = 1, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 2, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 3, UserName = "Melle", FullName ="Melle Ven",
                    EmailAddress = "melle@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 4, UserName = "Teije", FullName ="Teije Ven",
                    EmailAddress = "teije@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 5, UserName = "Marnix", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 6, UserName = "Janine", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 7, UserName = "Melle", FullName ="Melle Ven",
                    EmailAddress = "melle@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
                new User() {Id = 8, UserName = "Teije", FullName ="Teije Ven",
                    EmailAddress = "teije@marnixven.nl", Created = DateTime.Now, LastUpdated = DateTime.Now},
            };

        }

        public User Add(User newUser)
        {
            newUser.Id = _userList.Max(e => e.Id) + 1;
            _userList.Add(newUser);
            return newUser;
        }

        public User Delete(int id)
        {
            User userToDelete = _userList.FirstOrDefault(e => e.Id == id);

            if(userToDelete != null)
            {
                _userList.Remove(userToDelete);
            }

            return userToDelete;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int id)
        {
            return _userList.FirstOrDefault(e => e.Id == id);
        }

        public User Update(User updatedUser)
        {
            User user = _userList.FirstOrDefault(e => e.Id == updatedUser.Id);

            if(user != null)
            {
                user.FullName = updatedUser.FullName;
                user.UserName = updatedUser.UserName;
                user.EmailAddress = updatedUser.EmailAddress;
                user.Created = updatedUser.Created;
            }
            return user;
        }
    }
}
