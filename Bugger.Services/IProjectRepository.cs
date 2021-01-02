using Bugger.Models;
using System;
using System.Collections.Generic;

namespace Bugger.Services
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAllProjects();
    }
}
