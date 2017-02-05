using System.Collections.Generic;

namespace Continents.Models
{
    public interface IContinentService
    {
        List<Continent> GetAllContinents();
    }
}