using System;

namespace Domain
{
    public class ParentChildren
    {
        public string ParentId { get; set; }
        public Parent Parent { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
    }
}