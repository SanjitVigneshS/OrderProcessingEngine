using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    public abstract class ProductFactory
    {
        public abstract Product Create(string description);
    }
}
