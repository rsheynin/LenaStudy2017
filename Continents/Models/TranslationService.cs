using System;
using System.Collections.Generic;

namespace Continents.Models
{
    public class TranslationService: ITranslationService
    {
        public IResult Add(int langId, string text)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> GetTranslationByLanguage(int langId)
        {
            throw new NotImplementedException();
        }
    }
}