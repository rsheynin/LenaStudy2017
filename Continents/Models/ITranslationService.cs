using System.Collections.Generic;

namespace Continents.Models
{
    public interface ITranslationService
    {
        IResult Add(int langId, string text);

        Dictionary<int, string> GetTranslationByLanguage(int langId);
    }
}