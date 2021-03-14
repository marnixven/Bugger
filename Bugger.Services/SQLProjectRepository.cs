using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Services
{
    public class SQLProjectRepository : IProjectRepository
    {
        private readonly AppDbContext context;

        public SQLProjectRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return context.Projects;
        }
    }
}
