using System;

namespace Domain
{
    public class ParentConversations
    {
        public string ParentId { get; set; }
        public Parent Parent { get; set; }
        public string ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}