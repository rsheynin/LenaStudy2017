using System.Collections.Generic;

namespace Continents.Models
{
    public interface ICityService
    {
        List<City> GetAllCities();
        List<City> GetCitiesByContry(int contryId);
        List<City> GetCitiesByContinent(int continentId);
    }
}