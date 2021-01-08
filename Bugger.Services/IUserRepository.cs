using Bugger.Models;
using System;
using System.Collections.Generic;

namespace Bugger.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        User Update(User updatedUser);
        User Add(User newUser);
        User Delete(int id);
    }
}
