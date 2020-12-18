using System;
using System.Collections.Generic;

namespace Domain
{
    public class Parent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<ParentChildren> ParentChildren { get; set; }
        public ICollection<ParentMeetingsRequests> ParentMeetingsRequests { get; set; }
    }
}