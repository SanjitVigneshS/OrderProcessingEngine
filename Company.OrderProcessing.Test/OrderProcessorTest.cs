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

            //Assert the number of process outputs.
            Assert.AreEqual(2, orderProcessor.ProcessOrder(physicalProduct));
        }

        [TestMethod]
        public void TestBookProduct()
        {
            ProductFactory productFactory = new BookFactory();
            Product book = productFactory.Create("Fiction Novel");

            Assert.AreEqual(3, orderProcessor.ProcessOrder(book));
        }

        [TestMethod]
        public void TestNewMembershipProduct()
        {
            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("New Membership");

            Assert.AreEqual(2, orderProcessor.ProcessOrder(membership));
        }

        [TestMethod]
        public void TestMembershipUpgradeProduct()
        {
            ProductFactory productFactory = new MembershipFactory();
            Product membership = productFactory.Create("Upgrade Membership");

            Assert.AreEqual(2, orderProcessor.ProcessOrder(membership));
        }

        [TestMethod]
        public void TestSkiVideoProduct()
        {
            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Learning To Ski");

            Assert.AreEqual(1, orderProcessor.ProcessOrder(video));

            //Also assert if free video was added.
            Assert.AreEqual(2, video.Outputs[0].Products.Count);
        }

        [TestMethod]
        public void TestOtherVideoProduct()
        {
            ProductFactory productFactory = new VideoFactory();
            Product video = productFactory.Create("Movie");

            Assert.AreEqual(1, orderProcessor.ProcessOrder(video));
            //Free video should not be added.
            Assert.AreEqual(1, video.Outputs[0].Products.Count);
        }

        [TestCleanup]
        public void CleanUp()
        {
            orderProcessor = null;
            Console.WriteLine();
        }
    }
}
