namespace Calcualtor.Models
{

    public class ColorResult : IResult
    {
        public string Type
        {
            get
            {
                return "color";
            }
        }
        public float CountResult;

        public string Color;
    }
}
