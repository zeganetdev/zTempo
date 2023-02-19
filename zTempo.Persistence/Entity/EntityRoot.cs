using zTempo.Models;

namespace zTempo.Persistence.Entity
{
    internal class EntityRoot
    {
        public List<Project> Projects { get; set; }
        public List<Issue> Issues { get; set; }
        public List<Configuration> Configurations { get; set; }
    }
}
