using System;
using System.Collections.Generic;

namespace Domain
{
    public class Parent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<ParentChildren> ParentChildren { get; set; }
        public ICollection<ParentMeetingsRequests> ParentMeetingsRequests { get; set; }
        public ICollection<ParentConversations> ParentConversations { get; set; }
        public ICollection<Absense> Absence {get; set; }
    }
}