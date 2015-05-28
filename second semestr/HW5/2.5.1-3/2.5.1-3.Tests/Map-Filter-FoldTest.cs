using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._5._1_3.Tests
{
    [TestClass]
    public class FunctionTest
    {
        private List list;
        private Map_Filter_Fold functionClass;
 
        [TestInitialize]
        public void Initialize()
        {
            list = new List();
            functionClass = new Map_Filter_Fold();
        }

        [TestMethod]
        public void TestMapFunction()
        {
            Func <int, int> thisFunction = x => 3 * x;
            list.InsertElementToTail(5);
            functionClass.Map(list, thisFunction);
            Assert.AreEqual(15, list.getValue(0));
        }

        [TestMethod]
        public void TestFilterFunction1()
        {
            Func<int, bool> checkFunction = x => (x / 10) == 2;
            list.InsertElementToTail(89);
            list.InsertElementToTail(29);
            list.InsertElementToTail(78);
            list.InsertElementToTail(152);
            list.InsertElementToTail(20);
            list.InsertElementToTail(13);
            list.InsertElementToTail(25);
            list = functionClass.Filter(list, checkFunction);
            Assert.AreEqual(29, list.getValue(0));
            Assert.AreEqual(20, list.getValue(1));
            Assert.AreEqual(25, list.getValue(2));
        }

        [TestMethod]
        public void TestFilterFunction2()
        {
            Func<int, bool>checkFunction = x => (x / 10) == 9;
            list.InsertElementToTail(89);
            list.InsertElementToTail(29);
            list.InsertElementToTail(78);
            list.InsertElementToTail(152);
            list.InsertElementToTail(20);
            list.InsertElementToTail(13);
            list.InsertElementToTail(25);
            list = functionClass.Filter(list, checkFunction);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void TestFoldFunction()
        {
            Func<int, int, int> returningFunction = (acc, elem) => acc + elem;
            int currentAccValue = 0;
            list.InsertElementToTail(5);
            list.InsertElementToTail(9);
            list.InsertElementToTail(15);
            list.InsertElementToTail(1);
            list.InsertElementToTail(65);
            list.InsertElementToTail(5);
            currentAccValue = functionClass.Fold(list, currentAccValue, returningFunction);
            Assert.AreEqual(100, currentAccValue);
        }
    }
}
