namespace Continents.Models
{
    public class Contry: IDomain
    {
        public string Type
        {
            get { return "Contry"; }
        }
        public int Id { get; set; }
        public int TranslationId { get; set; }
    }
}