public class ChatMessage
{
    public int MessageId { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string MessageText { get; set; }
    public DateTime Timestamp { get; set; }

    // Navigatie-eigenschappen
    public Gebruiker Sender { get; set; }
    public Gebruiker Receiver { get; set; }
}