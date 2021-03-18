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
                new Project() {ProjectId = 1, ProjectName = "House", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new Project() {ProjectId = 2, ProjectName = "Car", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new Project() {ProjectId = 3, ProjectName = "Work", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new Project() {ProjectId = 4, ProjectName = "Bugger-project", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new Project() {ProjectId = 5, ProjectName = "Vacation", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
                new Project() {ProjectId = 6, ProjectName = "Other", AddDate = DateTime.Now,
                    LastUpdateUserID = 1, LastUpdateDate = DateTime.Now},
            };

        }
        public IEnumerable<Project> GetAllProjects()
        {
            return _ProjectList;
        }
    }
}