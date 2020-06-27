using Company.OrderProcessing.Models;
using System;

namespace Company.OrderProcessing.Core
{
    public class OrderProcessor
    {
        public int ProcessOrder(PhysicalProduct product)
        {
            return product.ProcessOutput();
        }
    }
}
