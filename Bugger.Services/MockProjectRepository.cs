using Bugger.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bugger.Services
{
    public class MockProjectRepository : IProjectRepository
    {
        private List<Project> _ProjectList;

        public MockProjectRepository()
        {
            _ProjectList = new List<Project>()
            {
                new Project() {ProjectId = 1, ProjectName = "BuggerApp", Created = DateTime.Now},
            };

        }
        public IEnumerable<Project> GetAllProjects()
        {
            return _ProjectList;
        }
    }
}