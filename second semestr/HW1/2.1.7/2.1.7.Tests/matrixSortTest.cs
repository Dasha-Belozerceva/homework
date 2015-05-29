using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1._7.Tests
{
    [TestClass]
    public class matrixSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 15;
            int n = 3;
            int m = 4;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; ++i)
                matrix[i] = new int[m];
            for (int i = 0; i < n; ++i)
               for (int j = 0; j < m; ++j)
               {
                   matrix[i][j] = value;
                   value--;
               }
            MatrixSort.SortMatrix(matrix, n, m);
            string outputMatrix = "";
            for(int i = 0; i < n; ++i)
                for(int j = 0; j < m; ++j)
                {
                    outputMatrix += matrix[i][j] + " ";
                }
            Assert.AreEqual("12 13 14 15 8 9 10 11 4 5 6 7 ", outputMatrix);
        }
    }
}
