namespace Calcualtor.Models
{
    public class ParityResultFactory : IResultFactory
    {
        public string Type
        {
            get
            {
                return Const.PARITYRESULT;
            }
        }
        public IResult Create(float res)
        {
            var result = new ParityResult();
            result.CountResult = res;
            result.Parity = res % 2 == 0 ? "even" : "odd";
            return result;
        }
    }
}