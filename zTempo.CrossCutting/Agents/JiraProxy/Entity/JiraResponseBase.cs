using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.Agents.JiraProxy.Entity
{
    internal class JiraResponseBase<T>
    {
        public string Self { get; set; }
        public int MaxResults { get; set; }
        public int StartAt { get; set; }
        public int Total { get; set; }
        public bool IsLast { get; set; }
        public T Values { get; set; }
        public T Issues { get; set; }
    }
}
