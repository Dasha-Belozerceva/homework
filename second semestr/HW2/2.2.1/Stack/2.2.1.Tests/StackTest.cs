using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackNamespace;

namespace _2._2._1.Tests
{
    [TestClass]
    public class StackTest
    {
        private Stack stack;
        
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack();
        }
       
        [TestMethod]
        public void PushTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(5);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }
        [TestMethod]
        public void PopTestWithTwoElementInStack()
        {
            stack.Push(6);
            stack.Push(8);
            stack.Push(4);
            Assert.AreEqual(4, stack.Top());
            stack.Pop();
            Assert.AreEqual(8, stack.Top());
        }
    }
}
