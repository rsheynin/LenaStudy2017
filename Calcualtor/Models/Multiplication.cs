namespace Calcualtor.Models
{

    public class Multiplication : ICounter
    {
       

        public string Type
        {
            get
            {
                return Const.MULTIPLICATION;
            }
        }

        public float Count(CalculateDTO obj)
        {
            var res = obj.A * obj.B;
            return res;
        }
    }
}
