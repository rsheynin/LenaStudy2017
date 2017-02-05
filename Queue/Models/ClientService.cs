using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Queue.DAL;

namespace Queue.Models
{
    public class ClientService : IClientService
    {
        private readonly ClientContext _dal;

        public ClientService()
        {
            _dal = new ClientContext();
        }
        public List<Client> GetAllNotServed()
        {
            var notServedClients = _dal.Clients
                .Where(x =>x.Status == ClientStatusEnum.NotServed).ToList();
            return notServedClients;
        }

        public bool ServeNextClient()
        {
            try
            {
                ChangeStatusToServed();

                ChangeStatusInServe();

                _dal.SaveChanges();
            }
            catch (Exception e)
            {
               //write to log exeption
                return false;
            }
            return true;
        }

        
        public Client GetCurrentClientInServe()
        {
            var inServe = _dal.Clients.FirstOrDefault(x => x.Status == ClientStatusEnum.InServe);
            return inServe;
        }

        public bool AddClient(string name)
        {

            try
            {
                var client = new Client()
                {
                    Id = _dal.Clients.Count(),
                    Name = name,
                    Status = ClientStatusEnum.NotServed,
                    DateTime = DateTime.Now
             
                };
                _dal.Clients.Add(client);
                _dal.SaveChanges();
               
            }
            catch (Exception exception)
            {
                // write to log exeption
                return false;
                
            }
             return true;
        }

        public void Dispose()
        {
            _dal?.Dispose();
        }

        private void ChangeStatusInServe()
        {
            var nextClient = GetAllNotServed().FirstOrDefault();
            if (nextClient != null)
            {
                nextClient.Status = ClientStatusEnum.InServe;
                _dal.Entry(nextClient).State = EntityState.Modified;
            }
        }

        private void ChangeStatusToServed()
        {
            var servedClient = GetCurrentClientInServe();
            if (servedClient != null)
            {
                servedClient.Status = ClientStatusEnum.Served;
                _dal.Entry(servedClient).State = EntityState.Modified;
            }
        }

    }
}