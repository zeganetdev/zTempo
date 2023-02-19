﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.Models
{
    public class Worklog
    {
        public List<WorklogAttribute> Attributes { get; set; }
        public string AuthorAccountId { get; set; }
        //public int BillableSeconds { get; set; }
        public string Description { get; set; }
        public int IssueId { get; set; }
        //public int RemainingEstimateSeconds { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public int TimeSpentSeconds { get; set; }
    }
}
