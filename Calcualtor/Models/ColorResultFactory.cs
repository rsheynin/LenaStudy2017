namespace Calcualtor.Models
{

    public class ColorResultFactory : IResultFactory
    {
        public string Type
        {
            get
            {
                return Const.COLORRESULT;
            }
        }
        public IResult Create(float res)
        {
            var result = new ColorResult();
            result.CountResult = res;
            result.Color = res % 2 == 0 ? "green" : "red";
            return result;
        }
    }
}
