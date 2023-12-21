namespace AccessibilityModels{

public class ErvaringsdeskundigeBeperking
{

    public int ErvaringsdeskundigeBeperkingId { get; set; }

    public int ErvaringsdeskundigeId { get; set; }
    public Ervaringsdeskundige Ervaringsdeskundige { get; set; }

    public int BeperkingId { get; set; }
    public Beperking Beperking { get; set; }
}

}