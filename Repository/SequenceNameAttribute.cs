using System;

namespace HomeBudgetTrackingSystem.Models
{
    public class SequenceNameAttribute : Attribute
    {
        public string Name { get; }

        public SequenceNameAttribute(string name)
        {
            Name = name;
        }
    }
}
