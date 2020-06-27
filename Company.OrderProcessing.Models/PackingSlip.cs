using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models
{
    public class PackingSlip
    {
        public string Description { get; set; }
        public PhysicalProduct Product { get; set; }
        public ShippingClient Target { get; set; }
        public PackingSlip(string description, PhysicalProduct product, ShippingClient target)
        {
            Description = description;
            Product = product;
            Target = target;
        }
        public int SendToTarget()
        {
            Console.WriteLine("Sending " + Product.Description + " to " + Target.Description);
            return Target.Send(this);
        }
    }
}
