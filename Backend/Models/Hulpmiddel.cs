namespace AccessibilityModels
{

    public class Hulpmiddel
    {

        public int HulpmiddelId { get; set; }

        public string Naam { get; set; }
        
        public List<ErvaringsdeskundigeHulpmiddel>? GebruiktDoorErvaringsdeskundigen { get; set; }


    }

}