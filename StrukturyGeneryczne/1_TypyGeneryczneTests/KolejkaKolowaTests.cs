using System;
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        //sprawdzamy czy podczas startu kolejka jest pusta
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();
            Assert.IsTrue(kolejka.CzyJestPusty);
        }
        [TestMethod]
        //sprawdzamy czy po zapisie do pelnej kolejki jest rzeczywiscie pełna
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.Zapisz(2.3);
            kolejka.Zapisz(3.5);
            kolejka.Zapisz(7.1);

            Assert.IsTrue(kolejka.JestPelny);
        }
        [TestMethod]
        //sprawdzamy czy element który pierwszy wszedł pierwszy wyjdzie
        public void PierwszyWchodziPierwszyWychdzi()
        {
            var kolejka = new KolejkaKolowa<string>(pojemnosc: 3);
            var wartosc1 = "4.3";
            var wartosc2 = "3.5";
           // var wartosc3 = 7.1;
            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);
            //   kolejka.Zapisz(wartosc3);

            //wartosci są sobie równe
            Assert.AreEqual(wartosc1, kolejka.Odczyt());
            Assert.AreEqual(wartosc2, kolejka.Odczyt());

            Assert.IsTrue(kolejka.CzyJestPusty);
        }
        [TestMethod]
        //sprawdzamy czy nadpisujemy wartosci gdy kolejka jest pełna
        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            

            var wartosci = new[] { 1.2, 3.4, 5.6,6.7,8.5,9.6 };

            foreach(var item in wartosci)
            {
                kolejka.Zapisz(item);
             
            }
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Odczyt());
            Assert.AreEqual(wartosci[4], kolejka.Odczyt());
            Assert.AreEqual(wartosci[5], kolejka.Odczyt());
            Assert.IsTrue(kolejka.CzyJestPusty);
        }
    }
}
