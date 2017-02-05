namespace Continents.Models
{
    public class City: IDomain
    {
        public string Type
        {
            get
            {
                return "City";
            }
        }
        public int Id { get; set; }
        public int TranslationId { get; set; }
    }
}