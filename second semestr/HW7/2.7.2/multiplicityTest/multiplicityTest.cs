using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._7._2;

namespace multiplicityTest
{
    [TestClass]
    public class multiplicityTest
    {

        [TestMethod]
        public void IsEmptyTest()
        {
            multiplicity<int> multiplicity = new multiplicity<int>();
            Assert.IsTrue(multiplicity.IsEmpty());
        }

        [TestMethod]
        public void AddIntElement()
        {
            multiplicity<int> multiplicity = new multiplicity<int>();
            multiplicity.AddElement(88);
            Assert.IsTrue(multiplicity.availabilityOFValue(88));
        }

        [TestMethod]
        public void AddStringElementTest()
        {
            multiplicity<string> multiplicity = new multiplicity<string>();
            multiplicity.AddElement("c#");
            Assert.IsTrue(multiplicity.availabilityOFValue("c#"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            multiplicity<int> multiplicity = new multiplicity<int>();
            multiplicity.AddElement(8);
            multiplicity.DeleteElement(8);
            Assert.IsTrue(multiplicity.IsEmpty());
        }

        [TestMethod]
        public void EmptyIntersectionTest()
        {
            multiplicity<int> multiplicity1 = new multiplicity<int>();
            multiplicity1.AddElement(8);
            multiplicity<int> multiplicity2 = new multiplicity<int>();
            multiplicity2.AddElement(2);
            multiplicity<int> intersection = new multiplicity<int>();
            intersection.AddElement(9876);
            intersection.Intersection(multiplicity1, multiplicity2);
            Assert.IsTrue(intersection.IsEmpty());
        }

        [TestMethod]
        public void IntersectionTest()
        {
            multiplicity<int> multiplicity1 = new multiplicity<int>();
            multiplicity1.AddElement(8);
            multiplicity1.AddElement(1);
            multiplicity<int> multiplicity2 = new multiplicity<int>();
            multiplicity2.AddElement(3);
            multiplicity2.AddElement(8);
            multiplicity<int> intersection = new multiplicity<int>();
            intersection.Intersection(multiplicity1, multiplicity2);
            Assert.IsFalse(intersection.IsEmpty());
        }

        [TestMethod]
        public void UnionTest()
        {
            multiplicity<int> multiplicity1 = new multiplicity<int>();
            multiplicity1.AddElement(1);
            multiplicity<int> multiplicity2 = new multiplicity<int>();
            multiplicity1.AddElement(9);
            multiplicity<int> union = new multiplicity<int>();
            union.Union(multiplicity1, multiplicity2);
            Assert.IsFalse(union.IsEmpty());
        }
    }
}
