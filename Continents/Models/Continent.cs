namespace Continents.Models
{
    public class Continent: IDomain
    {
        public string Type
        {
            get { return "Continent"; } 
        }
        public int Id;
        public int TranslationId;
    }
}