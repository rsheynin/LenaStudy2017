using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Queue.Models;

namespace Queue.Controllers
{
    public class ClientController : ApiController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [ActionName("Add")]
        public bool Add(string name)
        {
            var result = _clientService.AddClient(name);
            return result;
        }

        [HttpGet]
        [ActionName("InServe")]
        public Client GetCurrentClientInServe()
        {
            var result = _clientService.GetCurrentClientInServe();
            return result;
        }

        [HttpGet]
        [ActionName("NextClient")]
        public bool ServeNextClient()
        {
            var result = _clientService.ServeNextClient();
            return result;
        }


        [HttpGet]
        [ActionName("NotServed")]
        public List<Client> GetAllNotServed()
        {
            var result = _clientService.GetAllNotServed();
            return result;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clientService.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
