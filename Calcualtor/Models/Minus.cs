namespace Calcualtor.Models
{

    public class Minus : ICounter
    {
        public string Type
        {
            get
            {
                return Const.MINUS;
            }
        }

        public float Count(CalculateDTO obj)
        {
            var res = obj.A - obj.B;
            return res;
        }
    }
}
