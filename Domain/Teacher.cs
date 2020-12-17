using System;

namespace Domain
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Salutation Salutation { get; set; }
    }
}