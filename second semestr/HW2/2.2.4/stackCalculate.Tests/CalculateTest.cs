using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackInArrayNamespace;
using StackInListNamespace;

namespace _2._2._4.Tests
{
    [TestClass]
    public class CalculateTest
    {
        private InterfaceStack stack;
        private InterfaceStack arrayStack;
        private Calculator ListCalculator;
        private Calculator ArrayCalculator;
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack();
            ListCalculator = new Calculator(stack);

            arrayStack = new StackInArray();
            ArrayCalculator = new Calculator(arrayStack);
        }

        [TestMethod]
        public void ArrayStackSumTest()
        {
            arrayStack.Push(50);
            arrayStack.Push(40);

            Assert.AreEqual(90, ArrayCalculator.Sum());
        }

        [TestMethod]
        public void ArrayStackDifferenceTest()
        {
            arrayStack.Push(30);
            arrayStack.Push(50);

            Assert.AreEqual(20, ArrayCalculator.Difference());
        }

        [TestMethod]
        public void ArrayStackQuotientTest()
        {
            arrayStack.Push(2);
            arrayStack.Push(20);

            Assert.AreEqual(10, ArrayCalculator.Quotient());
        }

        [TestMethod]
        public void ArrayStackProductTest()
        {
            arrayStack.Push(3);
            arrayStack.Push(40);

            Assert.AreEqual(120, ArrayCalculator.Product());
        }

        [TestMethod]
        public void StackSumTest()
        {
            stack.Push(38);
            stack.Push(125);

            Assert.AreEqual(163, ListCalculator.Sum());
        }

        [TestMethod]
        public void StackDifferenceTest()
        {
            stack.Push(8);
            stack.Push(88);

            Assert.AreEqual(80, ListCalculator.Difference());
        }

        [TestMethod]
        public void StackQuotientTest()
        {
            stack.Push(32);
            stack.Push(1024);

            Assert.AreEqual(32, ListCalculator.Quotient());
        }

        [TestMethod]
        public void StackProductTest()
        {
            stack.Push(256);
            stack.Push(2);

            Assert.AreEqual(512, ListCalculator.Product());
        }
    }
}