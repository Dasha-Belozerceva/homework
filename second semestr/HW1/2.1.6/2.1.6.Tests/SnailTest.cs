using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1._6.Tests
{
    [TestClass]
    public class HelixTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 0;
            int[][] matrix = new int[3][];
            for (int i = 0; i < 3; ++i)
            {
                matrix[i] = new int[3];
            }
            for (int i = 0; i < 3; i++)
               for (int j = 0; j < 3; j++)
                {
                  matrix[i][j] = value;
                  value++;
                }
            string expected = "4 5 8 7 6 3 0 1 2 ";
            string outpootLine = Snail.OutpootBySnail(matrix);
            Assert.AreEqual(expected, outpootLine);
        }
    }
}
