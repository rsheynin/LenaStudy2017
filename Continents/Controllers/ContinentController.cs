using System.Collections.Generic;
using System.Web.Http;
using Continents.Models;

namespace Continents.Controllers
{
    public class ContinentController : ApiController
    {
        private readonly IContinentService _continentService;

        public ContinentController( IContinentService continentService)
        {
            _continentService = continentService;
        }

        [HttpGet]
        public List<Continent> GetAllContinents()
        {
            var continents = _continentService.GetAllContinents();
            return continents;
        }

    }
}