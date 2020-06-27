using Company.OrderProcessing.Core;
using Company.OrderProcessing.Models;
using System;
using System.Collections.Generic;

namespace Company.OrderProcessing.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor();

            ShippingClient client = new ShippingClient("Shipping");
            client.Link = "Link to Shipping Service";
            PhysicalProduct product = new PhysicalProduct("Table");
            product.Outputs = new List<PackingSlip>();
            product.Outputs.Add(new PackingSlip("Original Packing Slip", product, client));

            orderProcessor.ProcessOrder(product);
        }
    }
}
