using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.Agents.JiraProxy.Entity
{
    public class JiraIssue
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public JiraField Fields { get; set; }
    }
}
