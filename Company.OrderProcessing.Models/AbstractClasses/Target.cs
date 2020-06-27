using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    public abstract class Target
    {
        public string Description { get; set; }
        public string Link { get; set; }
        public Target(string description)
        {
            Description = description;
        }
        public abstract int Send(Output output);
    }
}
