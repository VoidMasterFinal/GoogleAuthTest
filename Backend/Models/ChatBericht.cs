namespace AccessibilityModels
{
    public class ChatBericht
    {
              public int Id { get; set; }
        public string BerichtInhoud { get; set; }

        public DateTime Tijdstempel { get; set; }

        public int AfzenderId { get; set; }

        public int OntvangerId { get; set; }

        public Ervaringsdeskundige AfzenderErvaringsdeskundige { get; set; }
        public Bedrijf AfzenderBedrijf { get; set; }

        public Ervaringsdeskundige OntvangerErvaringsdeskundige { get; set; }
        public Bedrijf OntvangerBedrijf { get; set; }

    }
}