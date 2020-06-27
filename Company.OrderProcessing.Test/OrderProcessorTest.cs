using Company.OrderProcessing.Core;
using Company.OrderProcessing.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Company.OrderProcessing.Test
{
    [TestClass]
    public class OrderProcessorTest
    {
        OrderProcessor orderProcessor;

        [TestInitialize]
        public void Initialize()
        {
            orderProcessor = new OrderProcessor();
        }

        [TestMethod]
        public void TestPhysicalProduct()
        {
            ShippingClient client = new ShippingClient("Shipping");
            client.Link = "Link to Shipping Service";
            PhysicalProduct product = new PhysicalProduct("Table");
            product.Outputs = new List<PackingSlip>();
            product.Outputs.Add(new PackingSlip("Original Packing Slip", product, client));

            Assert.IsFalse(orderProcessor.ProcessOrder(product) < 0);
        }
    }
}
