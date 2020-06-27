using Company.OrderProcessing.Core;
using Company.OrderProcessing.Models;
using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Factories;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
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

            ProductFactory productFactory = new PhysicalProductFactory();
            Product physicalProduct = productFactory.Create("Table");
            physicalProduct.Outputs = new List<PackingSlip>();
            physicalProduct.Outputs.Add(new PackingSlip("Original Packing Slip", physicalProduct, client));

            Assert.IsFalse(orderProcessor.ProcessOrder(physicalProduct) < 0);
        }

        [TestMethod]
        public void TestBookProduct()
        {
            ShippingClient shippingClient = new ShippingClient("Shipping");
            shippingClient.Link = "Link to Shipping Service";
            RoyaltyDepartmentClient royaltyClient = new RoyaltyDepartmentClient("Royalty Department");
            royaltyClient.Link = "Link to Royalty Department Service";

            ProductFactory productFactory = new PhysicalProductFactory();
            Product book = productFactory.Create("Fiction Novel");
            book.Outputs = new List<PackingSlip>();
            book.Outputs.Add(new PackingSlip("Original Packing Slip", book, shippingClient));
            book.Outputs.Add(new PackingSlip("Duplicate Packing Slip", book, royaltyClient));

            Assert.IsFalse(orderProcessor.ProcessOrder(book) < 0);
        }
    }
}
