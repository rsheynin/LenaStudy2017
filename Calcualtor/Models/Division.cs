namespace Calcualtor.Models
{

    public class Division : ICounter
    {
        public string Type
        {
            get
            {
                return Const.DIVISION;
            }
        }

        public float Count(CalculateDTO obj)
        {
            var res = obj.A /obj.B;
            return res;
        }
    }
}
