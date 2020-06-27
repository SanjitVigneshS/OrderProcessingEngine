using Company.OrderProcessing.Models.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    /// <summary>
    /// This class will be the base class for any rules like
    /// addition of discounts, freebies etc. It can also be
    /// used to manipulate what would be the target system
    /// that would get invoked.
    /// </summary>
    public abstract class Output
    {
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public Target Target { get; set; }
        public Output(string description, Product product, Target target)
        {
            Description = description;
            Products = new List<Product>();
            Products.Add(product);
            Target = target;
        }
        public virtual int SendToTarget()
        {
            Console.WriteLine("Processing " + Products[0].Description + " for " + Target.Description);
            return Target.Send(this);
        }
    }
}
