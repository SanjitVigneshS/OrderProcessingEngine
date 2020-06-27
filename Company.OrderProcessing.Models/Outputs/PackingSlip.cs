using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Outputs
{
    public class PackingSlip: Output
    {
        public PackingSlip(string description, Product product, Target target): base(description, product, target)
        {
        }

        public override int SendToTarget()
        {
            return base.SendToTarget();
        }
    }
}
