namespace Continents.Models
{

    public class Language: IDomain
    {
        public string Type
        {
            get
            {
                return "Language";
            }
        }
        public int Id { get; set; }
        public int TranslationId { get; set; }

    }
}
