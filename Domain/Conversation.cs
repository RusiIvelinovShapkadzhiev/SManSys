using System;
using System.Collections.Generic;

namespace Domain
{
    public class Conversation
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string MeetingRequestId { get; set; }
        public MeetingRequest MeetingRequest { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<ParentConversations> ParentConversations { get; set; }
        public ICollection<TeachersConversations> TeachersConversations { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}