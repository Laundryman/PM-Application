using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph.Models;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IAIdentityService
    {
        IEnumerable<User> GetUsers();
        Task<User> GetUser(string id, string appClientId);
        void CreateUser(User user);
        void DeleteUser(string id);
        //void SaveUser();

    }
}
