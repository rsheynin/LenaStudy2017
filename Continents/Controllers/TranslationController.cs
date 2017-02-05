using System.Collections.Generic;
using System.Web.Http;
using Continents.Models;

namespace Continents.Controllers
{
    public class TranslationController : ApiController
    {
        private readonly ITranslationService _translationService;

        public TranslationController( ITranslationService translationService)
        {
            _translationService = translationService;
        }

        [HttpGet]
        public Dictionary<int, string> GetTranslationByLanguage(int langId)
        {
            var translations = _translationService.GetTranslationByLanguage(langId);
            return translations;
        }

    }
}
