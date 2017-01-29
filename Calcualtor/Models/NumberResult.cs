namespace Calcualtor.Models
{
    public class NumberResult : IResult
    {
        public string Type
        {
            get
            {
                return "number";
            }
        }
        public float CountResult;

      
    }
}