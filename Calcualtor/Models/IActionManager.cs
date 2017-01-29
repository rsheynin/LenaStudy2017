using System.Collections.Generic;

namespace Calcualtor.Models
{

    public interface IActionManager
    {
        IResult Calculate(CalculateDTO obj);

        List<string> GetAllOperators();

        List<string> GetResultTypes();
    }
}
