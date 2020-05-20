using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OrderProcessor.Business.Core;

namespace OrderProcessor.Tests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderFactory factory = new OrderFactory();
            Assert.AreEqual(factory.ProcessAllOrder(), true);
        }
    }
}