using System.Collections.Generic;

namespace Calcualtor.Models
{

    public class ActionManager : IActionManager
    {
        private readonly IDictionary<string, ICounter> _actionDict;
        private readonly IDictionary<string, IResultFactory> _resultFactoryDict;

        public ActionManager(
            IDictionary<string, ICounter> actionDict, 
            IDictionary<string, IResultFactory> resultFactoryDict)
        {
            _actionDict = actionDict;
            _resultFactoryDict = resultFactoryDict;
        }
        public IResult Calculate(CalculateDTO obj)
        {
            #region comment

            //ICounter counter;
            //switch (obj.Operator)
            //{
            //    case Const.PLUS:
            //        counter = new Plus();            
            //        break;
            //    case Const.MINUS:
            //        counter = new Minus();
            //        break;
            //    case Const.MULTIPLICATION:
            //        counter = new Multiplication();
            //        break;
            //    case Const.DIVISION:
            //        counter = new Division();
            //        break;
            //    default:
            //        throw new Exception();
            //        break;

            //}
            //var res = counter.Count(obj);

            #endregion
            var res = _actionDict[obj.Operator].Count(obj);
            var result = _resultFactoryDict[obj.ResultType].Create(res);
            return result;
        }

        public List<string> GetAllOperators()
        {
            var operators = new List<string>();
            foreach (var item in _actionDict)
            {
                operators.Add(item.Key);
            }
            return operators;
        }

        public List<string> GetResultTypes()
        {
            var resultTypes = new List<string>();
            foreach (var item in _resultFactoryDict)
            {
                resultTypes.Add(item.Key);
            }
            return resultTypes;
        }
    }
}
