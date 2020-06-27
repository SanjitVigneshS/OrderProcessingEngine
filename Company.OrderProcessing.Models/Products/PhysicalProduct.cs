using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using System;
using System.Collections.Generic;

namespace Company.OrderProcessing.Models.Products
{
    public class PhysicalProduct: Product
    {
        internal PhysicalProduct(string description): base(description)
        {
            this.Description = description;
        }

        public override int ProcessOutputs()
        {
            return base.ProcessOutputs();
        }
    }
}
