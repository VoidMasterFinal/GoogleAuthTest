namespace AccessibilityModels
{
    public class ChatBericht
    {
        public int Id { get; set; }
        public string AfzenderId { get; set; }
        public int OntvangerId { get; set; }  // ID van de ontvanger (kan een ervaringsdeskundige of bedrijf zijn)
        public string BerichtInhoud { get; set; }
        public DateTime Tijdstempel { get; set; }

    }
}