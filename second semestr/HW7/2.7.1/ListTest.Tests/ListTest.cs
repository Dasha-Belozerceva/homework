using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._7._1;


namespace _2._7._1.Tests
{
    [TestClass]
    public class ListTest
    {
        private MyList<int> intList;
        private MyList<string> stringList;
        [TestInitialize]
        public void Initialize()
        {
            intList = new MyList<int>();
            stringList = new MyList<string>();
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(intList.IsEmpty());
            Assert.IsTrue(stringList.IsEmpty());
        }

        
        [TestMethod]
        public void GetValueTest()
        {
            intList.AddElementToHead(5);
            intList.AddElementToHead(3);
            intList.AddElementToHead(7);
            intList.AddElementToHead(8);
            Assert.AreEqual(3, intList.getValue(2));
        }
        
        [TestMethod]
        public void InsertIntInHeadTest()
        {
            intList.AddElementToHead(8);
            Assert.IsFalse(intList.IsEmpty());
            Assert.AreEqual(8, intList.GetHead().Value);
        }

        [TestMethod]
        public void InsertStringInHeadTest()
        {
            stringList.AddElementToHead("xoxoxo");
            Assert.IsFalse(stringList.IsEmpty());
            Assert.AreEqual("xoxoxo", stringList.GetHead().Value);
        }

        [TestMethod]
        public void InsertIntInTailTest()
        {
            intList.AddElementToHead(3);
            intList.AddElementInTail(2);
            Assert.AreEqual(2, intList.GetHead().Next.Value);
        }

        [TestMethod]
        public void InsertStringInTailTest()
        {
            stringList.AddElementToHead("xoxoxo");
            stringList.AddElementInTail("xoxo");
            Assert.AreEqual("xoxo", stringList.GetHead().Next.Value);
        }
        
        [TestMethod]
        public void InsertIntOnPositionTest()
        {
            intList.InsertElementToPosition(1, 0);
            Assert.IsFalse(intList.IsEmpty());
            Assert.AreEqual(1, intList.GetHead().Value);
            intList.InsertElementToPosition(3, 1);
            intList.InsertElementToPosition(5, 2);
            intList.InsertElementToPosition(8, 1);
            Assert.AreEqual(8, intList.GetHead().Next.Value);
        }

        [TestMethod]
        public void InsertStringOnPositionTest()
        {
            stringList.InsertElementToPosition("xoxoxo", 0);
            Assert.IsFalse(stringList.IsEmpty());
            Assert.AreEqual("xoxoxo", stringList.GetHead().Value);
            stringList.InsertElementToPosition("xoxo", 1);
            stringList.InsertElementToPosition("xo", 2);
            stringList.InsertElementToPosition("x", 1);
            Assert.AreEqual("x", stringList.GetHead().Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InsertOnNonexistentPositionTest()
        {
            intList.InsertElementToPosition(8, 2);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InsertOnNonexistentPositionTest2()
        {
            stringList.InsertElementToPosition("xoxoxo", -2);
        }
       
        [TestMethod]
        public void RemoveIntElementFromPositionTest()
        {
            intList.AddElementToHead(15);
            intList.AddElementToHead(6);
            intList.AddElementToHead(8);
            Assert.AreEqual(3, intList.Length);
            intList.RemoveElementFromPosition(1);
            Assert.AreEqual(2, intList.Length);
            Assert.AreEqual(15, intList.GetHead().Next.Value);
        }

        [TestMethod]
        public void RemoveStringElementFromPositionTest()
        {
            stringList.AddElementToHead("15");
            stringList.AddElementToHead("6");
            stringList.AddElementToHead("8");
            Assert.AreEqual(3, stringList.Length);
            stringList.RemoveElementFromPosition(1);
            Assert.AreEqual(2, stringList.Length);
            Assert.AreEqual("15", stringList.GetHead().Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveElementFromNonexistentPositionTest()
        {
            intList.AddElementToHead(8);
            intList.RemoveElementFromPosition(-6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveElementFromNonexistentPositionTest2()
        {
            stringList.AddElementToHead("7");
            stringList.AddElementToHead("8");
            stringList.RemoveElementFromPosition(5);
        }

        [TestMethod]
        public void removeIntElementByValueTest()
        {
            intList.AddElementToHead(8);
            intList.AddElementToHead(666);
            intList.AddElementToHead(654);
            intList.AddElementToHead(345);
            Assert.AreEqual(4, intList.Length);
            intList.removeElementByValue(666);
            Assert.AreEqual(3, intList.Length);
            Assert.AreEqual(8, intList.GetHead().Next.Next.Value);
        }

        [TestMethod]
        public void removeStringElementByValueTest()
        {
            stringList.AddElementToHead("8");
            stringList.AddElementToHead("666");
            stringList.AddElementToHead("654");
            stringList.AddElementToHead("345");
            Assert.AreEqual(4, stringList.Length);
            stringList.removeElementByValue("666");
            Assert.AreEqual(3, stringList.Length);
            Assert.AreEqual("8", stringList.GetHead().Next.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void removeIntElementByNonexistentValueTest()
        {
            intList.AddElementToHead(5);
            intList.removeElementByValue(6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void removeStringElementByNonexistentValueTest()
        {
            stringList.AddElementToHead("5");
            stringList.removeElementByValue("6");
        }
    }
}
