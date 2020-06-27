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
            ProductFactory productFactory = new PhysicalProductFactory();
            Product physicalProduct = productFactory.Create("Table");

            Assert.IsFalse(orderProcessor.ProcessOrder(physicalProduct) < 0);
        }

        [TestMethod]
        public void TestBookProduct()
        {
            ProductFactory productFactory = new BookFactory();
            Product book = productFactory.Create("Fiction Novel");

            Assert.IsFalse(orderProcessor.ProcessOrder(book) < 0);
        }

        [TestMethod]
        public void TestNewMembershipProduct()
        {
            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("New Membership");

            Assert.IsFalse(orderProcessor.ProcessOrder(membership) < 0);
        }

        [TestMethod]
        public void TestMembershipUpgradeProduct()
        {
            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("Upgrade Membership");

            Assert.IsFalse(orderProcessor.ProcessOrder(membership) < 0);
        }

        [TestMethod]
        public void TestSkiVideoProduct()
        {
            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Learning To Ski");

            Assert.IsFalse(orderProcessor.ProcessOrder(video) < 0);
        }

        [TestMethod]
        public void TestOtherVideoProduct()
        {
            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Movie");

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
