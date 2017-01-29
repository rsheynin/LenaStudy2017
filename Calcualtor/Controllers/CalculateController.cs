using Calcualtor.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Calcualtor.Controllers
{
    public class CalculateController : ApiController
    {
        private readonly IActionManager _actionManager;

        public CalculateController(IActionManager actionManager)
        {
            _actionManager = actionManager;
           
        }
        [ActionName("Operators")]
        [HttpGet]
        public List<string> GetOperators()
        {
            var operators = _actionManager.GetAllOperators();
            return operators;
        }
        [ActionName("ResultTypes")]
        [HttpGet]
        public List<string> GetResultTypes()
        {
            var resultTypes = _actionManager.GetResultTypes();
            return resultTypes;
        }

        [ActionName("Calculate")]
        [HttpPost]
        public IResult Calculate([FromBody]CalculateDTO obj)
        {
            var result = _actionManager.Calculate(obj);
            return result;
        }
        
        
    }
}
