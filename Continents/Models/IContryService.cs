using System.Collections.Generic;

namespace Continents.Models
{

    public interface IContryService
    {
        List<Contry> GetAllContries();
        List<Contry> GetContriesByContinent(int continentId);
    }
}