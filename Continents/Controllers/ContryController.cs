using System.Collections.Generic;
using System.Web.Http;
using Continents.Models;

namespace Continents.Controllers
{
    public class ContryController : ApiController
    {
        private readonly IContryService _contryService;

        public ContryController(  IContryService contryService)
        {
            _contryService = contryService;
        }

        [HttpGet]
        public List<Contry> GetAllContries()
        {
            var result = _contryService.GetAllContries();
            return result;
        }

        [HttpGet]
        public List<Contry> GetContriesByContinent(int continentId)
        {
            var result = _contryService.GetContriesByContinent(continentId);
            return result;
        }

    }
}