namespace AccessibilityModels
{
    public class Beperking
    {
        public int BeperkingId { get; set; }
        public string Type { get; set; }

        public List<ErvaringsdeskundigeBeperking>? Ervaringsdeskundigen { get; set; }

    }

}