using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealizationOfTheHashTable;

namespace _2._2._3.hash.Tests
{
    [TestClass]
    public class RealizationOfTheHashTableTest
    {
        private Hash hash;
        [TestInitialize]
        public void Initialize()
        {
            hash = new Hash();
        }
        [TestMethod]
        public void HashIsEmptyTest()
        {
            Assert.IsTrue(hash.HashIsEmpty());
        }
        [TestMethod]
        public void InsertElementToHashTableTest()
        {
            hash.InsertElementToHashTable("Expecto Patronum");
            Assert.IsFalse(hash.HashIsEmpty());
        }
        [TestMethod]
        public void AvailabilityOFElementInHashTableTest()
        {
            hash.InsertElementToHashTable("Crucio");
            hash.InsertElementToHashTable("Imperio");
            Assert.IsFalse(hash.AvailabilityOFElementInHashTable("Avada Kedavra"));
            Assert.IsTrue(hash.AvailabilityOFElementInHashTable("Crucio"));
        }
        [TestMethod]
        public void RemoveElementFromHashTableTest()
        {
            hash.InsertElementToHashTable("Alohomora");
            hash.InsertElementToHashTable("Lumos");
            hash.InsertElementToHashTable("Nox");
            hash.InsertElementToHashTable("Riddikulus");
            hash.InsertElementToHashTable("Wingardium Leviosa");
            Assert.IsTrue(hash.AvailabilityOFElementInHashTable("Wingardium Leviosa"));
            hash.RemoveElementFromHashTable("Wingardium Leviosa");
            Assert.IsFalse(hash.AvailabilityOFElementInHashTable("Wingardium Leviosa"));
        }
    }
}
