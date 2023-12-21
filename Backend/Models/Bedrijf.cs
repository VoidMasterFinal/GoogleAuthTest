
namespace AccessibilityModels
{
    public class Bedrijf : Gebruiker
    {
        public int BedrijfId { get; set; }
        
        public string Bedrijfsnaam { get; set; }

        public string BedrijfsInformatie { get; set; }

        public List<Onderzoek>? Onderzoeken { get; set; }

    }
}