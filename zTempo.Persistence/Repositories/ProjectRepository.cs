using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;
using zTempo.Persistence.SeedWork;

namespace zTempo.Persistence.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository() { }
    }
}
