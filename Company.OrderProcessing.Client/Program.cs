using Company.OrderProcessing.Core;
using Company.OrderProcessing.Models;
using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Factories;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Targets;
using System;
using System.Collections.Generic;

namespace Company.OrderProcessing.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor();

            ShippingAgent shippingClient = new ShippingAgent("Shipping");
            shippingClient.Link = "Link to Shipping Service";
            RoyaltyDepartmentClient royaltyClient = new RoyaltyDepartmentClient("Royalty Department");
            royaltyClient.Link = "Link to Royalty Department Service";

            ProductFactory productFactory = new PhysicalProductFactory();
            Product book = productFactory.Create("Fiction Novel");
            book.Outputs = new List<Output>();
            book.Outputs.Add(new PackingSlip("Original Packing Slip", book, shippingClient));
            book.Outputs.Add(new PackingSlip("Duplicate Packing Slip", book, royaltyClient));

            orderProcessor.ProcessOrder(book);
        }
    }
}
