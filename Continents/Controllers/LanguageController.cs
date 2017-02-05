using System.Collections.Generic;
using System.Web.Http;
using Continents.Models;

namespace Continents.Controllers
{
    public class LanguageController : ApiController
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        public List<Language> GetAllLanguages()
        {
            var languages = _languageService.GetAllLanguages();
            return languages;
        }

    }
}