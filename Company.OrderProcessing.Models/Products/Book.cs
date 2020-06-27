using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Products
{
    public class Book: Product
    {
        internal Book(string description): base(description)
        {
        }

        public override int ProcessOutputs()
        {
            return base.ProcessOutputs();
        }
    }
}
