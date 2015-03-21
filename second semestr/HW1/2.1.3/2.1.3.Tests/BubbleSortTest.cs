using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1._3.Tests
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int length = 5;
            int[] array = new int[length];
            array[0] = 5;
            array[1] = 0;
            array[2] = 65;
            array[3] = 48;
            array[4] = 15;
            BubbleSort.bubbleSort(array, length);
            Array expected = new [] {0, 5, 15, 48, 65};
            Assert.AreEqual(expected, array);
        }
    }
}
