using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1._2.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-1, Fibonacci.fibonacci(-6));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, Fibonacci.fibonacci(0));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, Fibonacci.fibonacci(1));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(8, Fibonacci.fibonacci(6));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(102334155, Fibonacci.fibonacci(40));
        }
    }
}
