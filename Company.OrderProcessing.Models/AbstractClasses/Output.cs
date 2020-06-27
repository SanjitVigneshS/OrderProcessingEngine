using Company.OrderProcessing.Models.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
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
            if(Products[0].Description == "Learning To Ski")
            {
                ProductFactory productFactory = new VideoFactory();
                Product video = productFactory.Create("First Aid");
                Products.Add(video);
            }
            return Target.Send(this);
        }
    }
}
