using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;

namespace zTempo.Application
{
    public interface IWorklogService
    {
        Task<List<Worklogs>> GetListByDateAsync(string accountId, string date);
        Task SaveAsync(Worklog worklog);
    }
}
