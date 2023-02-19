using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;
using zTempo.Persistence.Entity;
using zTempo.Persistence.SeedWork;

namespace zTempo.Persistence.Repositories
{
    public class ConfigurationRepository : Repository<Configuration>, IConfigurationRepository
    {
        public ConfigurationRepository() { }
    }
}
