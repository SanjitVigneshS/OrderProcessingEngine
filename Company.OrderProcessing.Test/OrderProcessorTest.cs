using Company.OrderProcessing.Core;
using Company.OrderProcessing.Models;
using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Factories;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Target client = new ShippingClient("Shipping");
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
            Target shippingClient = new ShippingClient("Shipping");
            shippingClient.Link = "Link to Shipping Service";
            Target royaltyClient = new RoyaltyDepartmentClient("Royalty Department");
            royaltyClient.Link = "Link to Royalty Department Service";

            ProductFactory productFactory = new BookFactory();
            Product book = productFactory.Create("Fiction Novel");
            book.Outputs = new List<PackingSlip>();
            book.Outputs.Add(new PackingSlip("Original Packing Slip", book, shippingClient));
            book.Outputs.Add(new PackingSlip("Duplicate Packing Slip", book, royaltyClient));

            Assert.IsFalse(orderProcessor.ProcessOrder(book) < 0);
        }

        [TestMethod]
        public void TestNewMembershipProduct()
        {
            Target userServiceAgent = new UserServiceAgent("User Agent");
            userServiceAgent.Link = "Link to Shipping Service";
            Target emailClient = new EmailClient("Email");
            emailClient.Link = "Link to Royalty Department Service";

            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("Fiction Novel");
            membership.Outputs = new List<PackingSlip>();
            membership.Outputs.Add(new PackingSlip("New Membership", membership, userServiceAgent));
            membership.Outputs.Add(new PackingSlip("New Membership", membership, emailClient));

            Assert.IsFalse(orderProcessor.ProcessOrder(membership) < 0);
        }

        [TestMethod]
        public void TestMembershipUpgradeProduct()
        {
            Target userServiceAgent = new UserServiceAgent("User Agent");
            userServiceAgent.Link = "Link to Shipping Service";
            Target emailClient = new EmailClient("Email");
            emailClient.Link = "Link to Royalty Department Service";

            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("Fiction Novel");
            membership.Outputs = new List<PackingSlip>();
            membership.Outputs.Add(new PackingSlip("Upgrade Membership", membership, userServiceAgent));
            membership.Outputs.Add(new PackingSlip("Upgrade Membership", membership, emailClient));

            Assert.IsFalse(orderProcessor.ProcessOrder(membership) < 0);
        }

        [TestMethod]
        public void TestSkiVideoProduct()
        {
            Target client = new ShippingClient("Shipping");
            client.Link = "Link to Shipping Service";

            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Learning To Ski");
            video.Outputs = new List<PackingSlip>();
            video.Outputs.Add(new PackingSlip("Original Packing Slip", video, client));

            Assert.IsFalse(orderProcessor.ProcessOrder(video) < 0);
        }

        [TestMethod]
        public void TestOtherVideoProduct()
        {
            Target client = new ShippingClient("Shipping");
            client.Link = "Link to Shipping Service";

            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Movie");
            video.Outputs = new List<PackingSlip>();
            video.Outputs.Add(new PackingSlip("Original Packing Slip", video, client));

            Assert.IsFalse(orderProcessor.ProcessOrder(video) < 0);
        }

        [TestCleanup]
        public void CleanUp()
        {
            orderProcessor = null;
            Console.WriteLine();
        }
    }
}
