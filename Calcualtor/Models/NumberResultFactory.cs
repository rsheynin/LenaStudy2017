namespace Calcualtor.Models
{
    public class NumberResultFactory : IResultFactory
    {
        public string Type
        {
            get
            {
                return Const.NUMBERRESULT;
            }
        }
        public IResult Create(float res)
        {
            var result = new NumberResult();
            result.CountResult = res;
            return result;
        }
    }
}