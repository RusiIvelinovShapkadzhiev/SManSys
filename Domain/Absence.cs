using System;

namespace Domain
{
    public class Absense
    {
        public string Id { get; set; }
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string ParentId { get; set; }
        public Parent Parent { get; set; }
    }
}