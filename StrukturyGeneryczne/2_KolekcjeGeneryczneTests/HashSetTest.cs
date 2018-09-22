using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);//porównuje które elementy są wspólne

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));//set1 zawiera 2 i 3
        }

        [TestMethod]
        public void UnionsectSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);//dodaje elementy rózne z seta 2

            Assert.IsTrue(set1.SetEquals(new[] {1,2,3, 4 }));//set1 zawiera 2 i 3
        }

        [TestMethod]
        public void SymmetricExcepSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);//różnica zbiorów czyli 1 i 4

            Assert.IsTrue(set1.SetEquals(new[] { 1,  4 }));//set1 zawiera 2 i 3
        }

        [TestMethod]
        public void Set()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(1);//różnica zbiorów czyli 1 i 4

            Assert.AreEqual(2, set1.Count);
        }


        [TestMethod]
        public void RemoveSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x=>x>1);//usuwa elementy wieksze od 1

            Assert.AreEqual(1, set1.Count);
        }

        [TestMethod]
        public void ContainsSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

        

            Assert.IsTrue(set1.Contains(3));
        }
    }
}
