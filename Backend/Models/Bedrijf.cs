
namespace AccessibilityModels
{
    public class Bedrijf : Gebruiker
    {

        public string Bedrijfsnaam { get; set; }

        public string BedrijfsInformatie { get; set; }

        public string Locatie { get; set; }

        public List<Onderzoek>? Onderzoeken { get; set; }

    }
}