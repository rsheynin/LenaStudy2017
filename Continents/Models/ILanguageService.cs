using System.Collections.Generic;

namespace Continents.Models
{
    public interface ILanguageService
    {
        List<Language> GetAllLanguages();
    }
}