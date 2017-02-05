using System.Collections.Generic;
using System.Web.Http;
using Continents.Models;

namespace Continents.Controllers
{
    public class CityController : ApiController
    {
        private readonly ICityService _cityService;

        public CityController( ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public List<City> GetAllCities()
        {
            var result = _cityService.GetAllCities();
            return result;
        }

        [HttpGet]
        public List<City> GetCitiesByContry(int contryId)
        {
            var result = _cityService.GetCitiesByContry(contryId);
            return result;
        }
        [HttpGet]
        public List<City> GetCitiesByContinent(int continentId)
        {
            var result = _cityService.GetCitiesByContinent(continentId);
            return result;
        }

    }
}