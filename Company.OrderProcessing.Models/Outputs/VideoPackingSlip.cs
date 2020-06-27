using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Outputs
{
    public class VideoPackingSlip : PackingSlip
    {
        public VideoPackingSlip(string description, Product product, Target target) : base(description, product, target)
        {
        }

        public override int SendToTarget()
        {
            if (Products[0].Description == "Learning To Ski")
            {
                Console.WriteLine("Adding free First Aid Video");
                ProductFactory productFactory = new VideoFactory();
                Product video = productFactory.Create("First Aid");
                Products.Add(video);
            }
            return base.SendToTarget();
        }
    }
}
