using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb[3]);
        }

        [TestMethod]
        public void ListaMozemyDodawacNaOkreslonejPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Insert(0,4);

            Assert.AreEqual(4,listaLiczb[0]);
        }

        [TestMethod]
        public void ListaMoezemyUsuwacElement()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Remove(2);

            Assert.AreEqual(listaLiczb[1],3); //porównuje 
            //Assert.IsTrue(listaLiczb.SequenceEqual(new [] { 1, 3 }));//szprawdza czy prawdą jest czy taka nowa tablica - za pomocą Linq
        }

        [TestMethod]
        public void ListaMoezemyUsuwacElementOOkreslnymIndeksie()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.RemoveAt(2);

            //Assert.AreEqual(listaLiczb[1], 3); //porównuje 
            Assert.IsTrue(listaLiczb.SequenceEqual(new [] { 1, 2 }));//szprawdza czy prawdą jest czy taka nowa tablica - za pomocą Linq
        }

        [TestMethod]
        public void ListaMoezemyWyszukiwaćIndexElementu()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            Assert.AreEqual(listaLiczb.IndexOf(3), 2);
        }

        [TestMethod]
        public void ListaMoezemyWyszukiwaćCzyZawiera()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            Assert.IsTrue(listaLiczb.Contains(3));
        }

        [TestMethod]
        public void ListaMozemyDodawacNaKoniecZakresLiczb()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            var zakres= new List<int> { 4, 5, 6,7 };
            listaLiczb.AddRange(zakres);

            Assert.AreEqual(7, listaLiczb[6]);
        }

        [TestMethod]
        public void UzyciePeek()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.AreEqual(1, kolejka.Peek());
        }

        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.IsTrue( kolejka.Contains(3));//czy zawiera
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            var tablica = kolejka.ToArray();
           
            Assert.IsTrue(kolejka.Count==tablica.Length);
            kolejka.Dequeue();
            Assert.AreEqual(1,tablica[0]);
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            kolejka.Clear();

            Assert.AreEqual(0,kolejka.Count);
        }
    }
}
