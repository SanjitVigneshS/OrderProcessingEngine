using Company.OrderProcessing.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Products
{
    public class Membership : Product
    {
        public Membership(string description) : base(description)
        {
        }

        public override int ProcessOutputs()
        {
            return base.ProcessOutputs();
        }
    }
}
