namespace Calcualtor.Models
{
    public interface ICounter
    {
        string Type { get; }
        float Count(CalculateDTO obj); 
    }

    //public interface DemoAPICtrl
    //{
    //    List<string> GET();

    //    IResult POST(CalculateDTO obj);
    //}
}
