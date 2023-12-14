namespace AccessibilityModels
{

    public class Hulpmiddel
    {

        public int HulpmiddelId { get; set; }

        public string Naam { get; set; }

        public int? ErvaringsdeskundigeId { get; set; } // Foreign Key
        
        public Ervaringsdeskundige Ervaringsdeskundige { get; set; }


    }

}