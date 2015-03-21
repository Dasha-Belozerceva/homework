using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1._1.Tests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(120, Factorial.factorial(5));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(40320, Factorial.factorial(8));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Factorial.factorial(-5));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, Factorial.factorial(0));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(479001600, Factorial.factorial(12));
        }
    }
    

}
