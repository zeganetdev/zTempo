using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.Models;

namespace zTempo.Application
{
    public interface IUserService
    {
        void ConfigurateJira();
        User GetUser();
        Task<User> GetUserAsync();
        void Save(User user);
    }
}
