namespace ArifmeticTree.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _2._4._1;

    [TestClass]
    public class ParseTreeTest
    {
        private Tree tree1;
        private Tree tree2;
        [TestInitialize]
        public void Initialize()
        {
            tree1 = new Tree("(* (- 12 2) (+ 5 5))");
            tree2 = new Tree("( / 5 0 ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExceptionForDivisionTest()
        {
            tree2.CalculateTree();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExceptionInadmissibleSymbolTest()
        {
            Tree tree3 = new Tree("( / 5 k )");
            tree3.CalculateTree();
        }

        [TestMethod]
        public void CalculateTest()
        {
            Assert.AreEqual(tree1.CalculateTree(), 100);
        }

        [TestMethod]
        public void PrintTest()
        {
            Assert.AreEqual(tree1.PrintTree(), "(* (- 12 2) (+ 5 5))");
        }        
    }
}   
