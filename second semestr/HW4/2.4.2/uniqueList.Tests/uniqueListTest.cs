using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._4._2;
using uniqueListNamespace;
using MyList;



namespace uniqueListTest
{
    [TestClass]
    public class ListTest
    {
        public List list;
        private UniqueList uniqueList;
       
        [TestInitialize]
        public void Initialize()
        {
            list = new List();
            uniqueList = new UniqueList();
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void SizeOfListTest()
        {
            Assert.AreEqual(0, list.SizeOfList());
            list.InsertElementToHead(2);
            Assert.AreEqual(1, list.SizeOfList());
        }

        [TestMethod]
        public void GetValueTest()
        {
            list.InsertElementToHead(5);
            list.InsertElementToHead(3);
            list.InsertElementToHead(7);
            list.InsertElementToHead(8);
            Assert.AreEqual(3, list.getValue(2));
        }
        [TestMethod]
        public void InsertInHeadTest()
        {
            list.InsertElementToHead(8);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(8, list.head.Value);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ContainedValueInListException))]
        public void InsertInHeadTest2()
        {
            uniqueList.InsertElementToHead(8);
            uniqueList.InsertElementToHead(8);
        }

        [TestMethod]
        public void InsertInTailTest()
        {
            list.InsertElementToHead(3);
            list.InsertElementToTail(2);
            Assert.AreEqual(2, list.head.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ContainedValueInListException))]
        public void InsertInTailTest2()
        {
            uniqueList.InsertElementToHead(8);
            uniqueList.InsertElementToTail(8);
        }

        [TestMethod]
        public void InsertOnPositionTest()
        {
            list.InsertElementToPosition(1, 0);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(1, list.head.Value);
            list.InsertElementToPosition(3, 1);
            list.InsertElementToPosition(5, 2);
            list.InsertElementToPosition(8, 1);
            Assert.AreEqual(8, list.head.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ContainedValueInListException))]
        public void InsertInHeadTest3()
        {
            uniqueList.InsertElementToHead(8);
            uniqueList.InsertElementToHead(7);
            uniqueList.InsertElementToHead(6);
            uniqueList.InsertElementToPosition(7, 1);
        }

        [TestMethod]
        public void InsertOnNonexistentPositionTest()
        {
            list.InsertElementToPosition(8, 2);
            Assert.IsTrue(list.IsEmpty());
        }
        [TestMethod]
        public void InsertOnNonexistentPositionTest2()
        {
            list.InsertElementToPosition(8, -2);
            Assert.IsTrue(list.IsEmpty());
        }
        [TestMethod]
        public void RemoveElementFromPositionTest()
        {
            list.InsertElementToHead(15);
            list.InsertElementToHead(6);
            list.InsertElementToHead(8);
            Assert.AreEqual(3, list.SizeOfList());
            list.RemoveElementFromPosition(1);
            Assert.AreEqual(2, list.SizeOfList());
            Assert.AreEqual(15, list.head.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(NoElementInTheListExeption))]
        public void RemoveElementFromPositionTest2()
        {
            uniqueList.InsertElementToHead(8);
            uniqueList.InsertElementToHead(7);
            uniqueList.RemoveElementFromPosition(2);
        }

        
        [TestMethod]
        public void removeElementByValueTest()
        {
            list.InsertElementToHead(8);
            list.InsertElementToHead(666);
            list.InsertElementToHead(654);
            list.InsertElementToHead(345);
            Assert.AreEqual(4, list.SizeOfList());
            list.removeElementByValue(666);
            Assert.AreEqual(3, list.SizeOfList());
            Assert.AreEqual(8, list.head.Next.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(NoElementInTheListExeption))]
        public void RemoveElementByValueTest2()
        {
            uniqueList.InsertElementToHead(8);
            uniqueList.InsertElementToHead(7);
            uniqueList.removeElementByValue(3);
        }
        
    }
}