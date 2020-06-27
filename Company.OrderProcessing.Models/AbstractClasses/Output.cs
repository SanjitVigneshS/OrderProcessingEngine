using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    public abstract class Output
    {
        public string Description { get; set; }
        public Product Product { get; set; }
        public Target Target { get; set; }
        public Output(string description, Product product, Target target)
        {
            Description = description;
            Product = product;
            Target = target;
        }
        public virtual int SendToTarget()
        {
            Console.WriteLine("Processing " + Product.Description + " for " + Target.Description);
            return Target.Send(this);
        }
    }
}
