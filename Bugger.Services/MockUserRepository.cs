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
                new User() {ID = 1, UserName = "Marnix", Password = "test", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", isAdmin = true, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 2, UserName = "Janine", Password = "test", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", isAdmin = false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 3, UserName = "Melle", Password = "test", FullName ="Melle Ven",
                    EmailAddress = "melle@marnixven.nl", isAdmin = false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 4, UserName = "Teije", Password = "test", FullName ="Teije Ven",
                    EmailAddress = "teije@marnixven.nl", isAdmin = false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 5, UserName = "Marnix", Password = "test", FullName ="Marnix Ven",
                    EmailAddress = "mail@marnixven.nl", isAdmin = true, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 6, UserName = "Janine", Password = "test", FullName ="Janine Driessen",
                    EmailAddress = "janine@marnixven.nl", isAdmin =false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 7, UserName = "Melle", Password = "test", FullName ="Melle Ven",
                    EmailAddress = "melle@marnixven.nl", isAdmin = false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new User() {ID = 8, UserName = "Teije", Password = "test", FullName ="Teije Ven",
                    EmailAddress = "teije@marnixven.nl", isAdmin = false, AddDate= DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
            };

        }

        public User Add(User newUser)
        {
            newUser.ID = _userList.Max(e => e.ID + 1);
            _userList.Add(newUser);
            return newUser;
        }

        public User Delete(int Userid)
        {
            User userToDelete = _userList.FirstOrDefault(e => e.ID == Userid);

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
            return _userList.FirstOrDefault(e => e.ID == id);
        }

        public User Update(User updatedUser)
        {
            User user = _userList.FirstOrDefault(e => e.ID == updatedUser.ID);

            if(user != null)
            {
                user.FullName = updatedUser.FullName;
                user.UserName = updatedUser.UserName;
                user.Password = updatedUser.Password;
                user.EmailAddress = updatedUser.EmailAddress;
                user.isAdmin = updatedUser.isAdmin;

            }
            return user;
        }
    }
}
