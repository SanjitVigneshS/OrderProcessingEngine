using Company.OrderProcessing.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Products
{
    public class Video : Product
    {
        internal Video(string description) : base(description)
        {
        }

        public override int ProcessOutputs()
        {
            return base.ProcessOutputs();
        }
    }
}
