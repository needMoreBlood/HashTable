using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hashTable;

namespace hashtable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeElements()
        {
            var check = new HashTable(3);

            for (int i = 0; i < 3; i++)
            {
                check.PutPair(i, i);
            }

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(check.GetValueByKey(i), i);

            }
        }

        [TestMethod]
        public void EquialElements()
        {
            var check = new HashTable(2);

            check.PutPair("a", 3232);
            check.PutPair("a", 342);
            
            Assert.AreEqual(check.GetValueByKey("a"), 342);
        }

        [TestMethod]
        public void TenHElements()
        {
            var check = new HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                check.PutPair(i, i);
            }

            Assert.AreEqual(check.GetValueByKey(1), 1);
        }

        [TestMethod]
        public void TenHElements2()
        {
            var check = new HashTable(11000);

            for (int i = 0; i < 10000; i++)
            {
                check.PutPair(i, i + 1);
            }

            for (int i = 10000; i < 11000; i++)
            {
                Assert.AreEqual(check.GetValueByKey(i), null);
            }
        }
    }
}
