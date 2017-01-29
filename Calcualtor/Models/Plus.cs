namespace Calcualtor.Models
{

    public class Plus : ICounter
    {
        public string Type
        {
            get
            {
                return Const.PLUS;
            }
        }

        public float Count(CalculateDTO obj)
        {
            var res = obj.A + obj.B;
            return res;
        }
    }
}
