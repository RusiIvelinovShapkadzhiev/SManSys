namespace Domain
{
    public class TeachersConversations
    {
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public string ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}