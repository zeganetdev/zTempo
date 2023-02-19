using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;

namespace zTempo.Application
{
    public interface IConfigurationService
    {
        List<Configuration> GetConfigurations();
        void Save(Configuration configurations);
    }
}
