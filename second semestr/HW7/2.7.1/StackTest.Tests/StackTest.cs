using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._7._1;

namespace StackTest.Tests
{
    [TestClass]
    public class StackTest
    {
        private Stack<int> intStack;
        private Stack<string> stringStack;

        [TestInitialize]
        public void Initialize()
        {
            intStack = new Stack<int>();
            stringStack = new Stack<string>();
        }

        [TestMethod]
        public void IntPushTest()
        {
            intStack.Push(4);
            Assert.IsFalse(intStack.IsEmpty());
        }

        [TestMethod]
        public void IntPopReturnValueTest()
        {
            intStack.Push(5);
            Assert.AreEqual(5, intStack.Pop());
        }

        [TestMethod]
        public void IntPopTest()
        {
            intStack.Push(6);
            intStack.Pop();
            Assert.IsTrue(intStack.IsEmpty());
        }

        [TestMethod]
        public void StringPushTest()
        {
            stringStack.Push("xoxoxo");
            Assert.IsFalse(stringStack.IsEmpty());
        }

        [TestMethod]
        public void stringPopTest()
        {
            stringStack.Push("xoxoxo");
            stringStack.Pop();
            Assert.IsTrue(stringStack.IsEmpty());
        }

        [TestMethod]
        public void stringPopReturnValueTest()
        {
            stringStack.Push("xoxoxo");
            stringStack.Push("xoxo");
            stringStack.Push("xo");
            Assert.AreEqual("xo", stringStack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopIntFromEmptyStack()
        {
            intStack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopStringFromEmptyStack()
        {
            stringStack.Pop();
        }
    }
}
