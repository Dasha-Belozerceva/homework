using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateOfList;

namespace _2._3._2.Tests
{
    [TestClass]
    public class ListTest
    {
        private List list;
        [TestInitialize]
        public void Initialize()
        {
            list = new List();
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
            list.InsertElementToHead("cat");
            Assert.AreEqual(1, list.SizeOfList());
        }

        [TestMethod]
        public void GetValueTest()
        {
            list.InsertElementToHead("cat");
            list.InsertElementToHead("dog");
            list.InsertElementToHead("parrot");
            list.InsertElementToHead("monkey");
            Assert.AreEqual("dog", list.GetValue(2));
        }
        [TestMethod]
        public void InsertInHeadTest()
        {
            list.InsertElementToHead("gate 21");
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual("gate 21", list.GetValue(0));
        }
        [TestMethod]
        public void InsertInTailTest()
        {
            list.InsertElementToHead("element in head");
            list.InsertElementToTail("element in tail");
            Assert.AreEqual("element in tail", list.GetValue(1));
        }
        [TestMethod]
        public void InsertOnPositionTest()
        {
            list.InsertElementToPosition("the lord of the rings is the best film ever", 0);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual("the lord of the rings is the best film ever", list.GetValue(0));
            list.InsertElementToPosition("but Interstate 60 is also the good movie", 1);
            list.InsertElementToPosition("Back to the Future may also compete for first place in the top movies", 2);
            list.InsertElementToPosition("I hate cheap American action movie", 1);
            Assert.AreEqual("I hate cheap American action movie", list.GetValue(1));
        }

        [TestMethod]
        public void InsertOnNonexistentPositionTest()
        {
            list.InsertElementToPosition("Per aspera ad astra", 2);
            Assert.IsTrue(list.IsEmpty());
        }
        [TestMethod]
        public void InsertOnNonexistentPositionTest2()
        {
            list.InsertElementToPosition("Amor wincit omnia", -2);
            Assert.IsTrue(list.IsEmpty());
        }
        [TestMethod]
        public void RemoveElementFromPositionTest()
        {
            list.InsertElementToHead("Cogito ergo sum");
            list.InsertElementToHead("Divide et impera");
            list.InsertElementToHead("O tempora! O mores!");
            Assert.AreEqual(3, list.SizeOfList());
            list.RemoveElementFromPosition(1);
            Assert.AreEqual(2, list.SizeOfList());
            Assert.AreEqual("Cogito ergo sum", list.GetValue(1));
        }

        [TestMethod]
        public void RemoveElementFromNonexistentPositionTest()
        {
            list.InsertElementToHead("Veni, vidi, vici");
            list.RemoveElementFromPosition(-6);
            Assert.AreEqual(1, list.SizeOfList());
        }

        [TestMethod]
        public void RemoveElementFromNonexistentPositionTest2()
        {
            list.InsertElementToHead("Art longa, vita brevis");
            list.InsertElementToHead("Est in media verum");
            list.RemoveElementFromPosition(5);
            Assert.AreEqual(2, list.SizeOfList());
        }

        [TestMethod]
        public void removeElementByValueTest()
        {
            list.InsertElementToHead("8");
            list.InsertElementToHead("666");
            list.InsertElementToHead("654");
            list.InsertElementToHead("345");
            Assert.AreEqual(4, list.SizeOfList());
            list.RemoveElementByValue("666");
            Assert.AreEqual(3, list.SizeOfList());
            Assert.AreEqual("8", list.GetValue(2));
        }
        [TestMethod]
        public void removeElementByNonexistentValueTest()
        {
            list.InsertElementToHead("5");
            list.RemoveElementByValue("6");
            Assert.AreEqual(1, list.SizeOfList());
            Assert.AreEqual("5", list.GetValue(0));
        }
    }
}