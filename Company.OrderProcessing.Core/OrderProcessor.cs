using Company.OrderProcessing.Models;
using Company.OrderProcessing.Models.AbstractClasses;
using System;

namespace Company.OrderProcessing.Core
{
    public class OrderProcessor
    {
        public int ProcessOrder(Product product)
        {
            return product.ProcessOutputs();
        }
    }
}
