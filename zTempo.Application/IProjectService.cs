using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;

namespace zTempo.Application
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjectsByName(string name);
        List<Project> GetProjects();
        void Save(List<Project> projects);
    }
}
