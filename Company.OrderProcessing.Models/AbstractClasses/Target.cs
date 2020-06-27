using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    /// <summary>
    /// The target system which can be a service agent
    /// or a database layer or a file writer.
    /// </summary>
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
