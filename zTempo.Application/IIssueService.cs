using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;

namespace zTempo.Application
{
    public interface IIssueService
    {
        Task<List<Issue>> GetIssuesByName(string projectKey, string summary);
        List<Issue> GetIssues();
        List<Issue> GetIssues(string projectId);
        void Save(List<Issue> issues);
        void Remove(Issue issue);
    }
}
