public class ChatMessage
{
    public int ChatMessageId { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }

    // Navigatie-eigenschappen
    public Gebruiker Sender { get; set; }
    public Gebruiker Receiver { get; set; }
}