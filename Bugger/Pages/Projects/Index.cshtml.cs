using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bugger.Models;
using Bugger.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bugger.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly IProjectRepository projectRepository;

        public IEnumerable<Project> Projects { get; set; }

        public IndexModel(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        
        public void OnGet()
        {
            Projects = projectRepository.GetAllProjects();
        }
    }
}
