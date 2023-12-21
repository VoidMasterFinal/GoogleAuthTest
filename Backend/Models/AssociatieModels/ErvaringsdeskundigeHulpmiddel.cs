namespace AccessibilityModels
{
    public class ErvaringsdeskundigeHulpmiddel
    {

        public int ErvaringsdeskundigeHulpmiddelId { get; set; }

        public int ErvaringsdeskundigeId { get; set; }
        public Ervaringsdeskundige? Ervaringsdeskundige { get; set; }

        public int HulpmiddelId { get; set; }
        public Hulpmiddel? Hulpmiddel { get; set; }
    }

}