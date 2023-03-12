using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.Agents.TempoProxy.Entity
{
    internal class TempoResponseBase<T>
    {
        public string Self { get; set; }
        public TempoMetadata Metadata { get; set; }
        public T Results { get; set; }
    }
}
