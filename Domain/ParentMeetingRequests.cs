using System;

namespace Domain
{
    public class ParentMeetingsRequests
    {
        public string ParentId { get; set; }
        public Parent Parent { get; set; }
        public string MeetingRequestId { get; set; }
        public MeetingRequest MeetingRequest { get; set; }
    }
}