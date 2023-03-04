using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.Agents.JiraProxy.Entity
{
    public class JiraUser
    {
        public string Self { get; set; }
        public string AccountId { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
        public string Locale { get; set; }
        public string Expand { get; set; }
    }
}
