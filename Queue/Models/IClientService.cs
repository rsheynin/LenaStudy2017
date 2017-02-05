using System;
using System.Collections.Generic;

namespace Queue.Models
{
    public interface IClientService : IDisposable
    {
        List<Client> GetAllNotServed();
        bool ServeNextClient();
        Client GetCurrentClientInServe();
        bool AddClient(string name);

    }
}