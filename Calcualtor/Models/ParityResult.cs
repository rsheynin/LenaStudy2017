namespace Calcualtor.Models
{
    public class ParityResult : IResult
    {
        public string Type
        {
            get
            {
                return "parity";
            }
        }
        public string Parity;
        public float CountResult;


    }
}