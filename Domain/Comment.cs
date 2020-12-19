using System;

namespace Domain
{
    public class Comment
    {
        public string Id { get; set; }
        public string AutorName { get; set; }
        public DateTime DateCreation { get; set; }
        public string ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}