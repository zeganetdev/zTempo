using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.Agents.TempoProxy.Entity
{
    public class TempoWorklogs
    {
        public string Self { get; set; }
        public int TempoWorklogId { get; set; }
        public TempoIssue Issue { get; set; }
        public int TimeSpentSeconds { get; set; }
        public int BillableSeconds { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public TempoAuthor Author { get; set; }
        public TempoAttributes Attributes { get; set; }
    }

}
