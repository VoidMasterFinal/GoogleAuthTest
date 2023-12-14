namespace AccessibilityModels
{

    public class Onderzoek
    {

        public int OnderzoekId { get; set; }

        public string Titel { get; set; }

        public string KorteBeschrijving { get; set; }

        public DateTime Datum { get; set; }

        public string Locatie { get; set; }

        public string Beloning { get; set; }

        public string SoortOnderzoek { get; set; }

        public string StatusDeelname { get; set; }

        public Bedrijf UitvoerendBedrijf { get; set; }

        public List<OnderzoekDeelname>? OnderzoekDeelnames { get; set; }



    }

}