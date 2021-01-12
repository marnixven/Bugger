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
                new Project() {Id = 1, ProjectName = "House", Created = DateTime.Now},
                new Project() {Id = 2, ProjectName = "Car", Created = DateTime.Now},
                new Project() {Id = 3, ProjectName = "Work", Created = DateTime.Now},
                new Project() {Id = 4, ProjectName = "Sports", Created = DateTime.Now},
                new Project() {Id = 5, ProjectName = "Vacation", Created = DateTime.Now},
                new Project() {Id = 6, ProjectName = "Other", Created = DateTime.Now},
            };

        }
        public IEnumerable<Project> GetAllProjects()
        {
            return _ProjectList;
        }
    }
}