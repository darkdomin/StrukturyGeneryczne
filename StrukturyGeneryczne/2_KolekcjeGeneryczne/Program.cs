using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista();
            //Kolejka();
            //Stos();
            //HaszSet();
            //LinkedList();
            //LinkedList2();
            //Dictionary();
            //SortedDictionary();
            //SortedList();

           // SortedSet();
            Console.ReadKey();

        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>(); //cos w stylu hashset
            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            var set2 = new SortedSet<string>(); //cos w stylu hashset
            set2.Add("dominik");
            set2.Add("monika");
            set2.Add("pawel");
            set2.Add("marek");
            set2.Add("magda");
            set2.Add("tomek");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedList<string, List<Pracownik>>();
            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                                                             new Pracownik { Imie = "Marcin", Nazwisko = "Bień" }});

            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Marcin", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomek", Nazwisko = "Wróbel" } });

            pracownicy.Add("Księgowość", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                                                             new Pracownik { Imie = "Jurek", Nazwisko = "Pytel" },
                                                             new Pracownik { Imie = "Robert", Nazwisko = "Stach" } });


            foreach (var item in pracownicy)
            {
                Console.WriteLine("ilosc pracowników w dziale {0} wynosi: {1} ", item.Key, item.Value.Count);
            }
        }

        private static void Dictionary()
        {
            // Dictionary<string, Pracownik> pracownicy = new Dictionary<string, Pracownik>();
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" } ,
                                                               new Pracownik { Nazwisko ="Kowal" },
                                                               new Pracownik { Nazwisko ="Kaczor" }});

            pracownicy["ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "zabielski" } ,
                                                               new Pracownik { Nazwisko ="Bogacki" },
                                                               });
            //foreach (var item in pracownicy)
            //{
            //    foreach (var p in item.Value)
            //    {
            //        Console.WriteLine(item.Key+" "+ p.Nazwisko);
            //    }

            //}
            foreach (var p in pracownicy["informatyka"])
            {
                Console.WriteLine(p.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var pierwszy = lista.First;//odniesienie do elementu pierwszego
            var ostatni = lista.Last;
            lista.AddAfter(pierwszy, 10);
            lista.AddBefore(pierwszy, 20);

            var wezel = lista.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);

            lista.AddLast(1);

            foreach (var p in lista)
            {
                Console.WriteLine(p);
            }
        }

        private static void HaszSet()
        {
            Console.WriteLine("HashSet");
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var pracownik = new Pracownik { Imie = "dominik", Nazwisko = "karolak" };
            set.Add(pracownik);
            set.Add(new Pracownik { Imie = "Monisia", Nazwisko = "dupsiai" });
            set.Add(pracownik);

            foreach (var p in set)
            {
                Console.WriteLine(p.Imie);
            }
        }

        private static void Stos()
        {
            Console.WriteLine("Stos");
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Robak" });
            stos.Push(new Pracownik { Imie = "Ala", Nazwisko = "Polak" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Jurek" });

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Robak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ala", Nazwisko = "Polak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Jurek" });
            Console.WriteLine("Kolejka");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Lista()
        {
            Console.WriteLine("Lista");
            List<int> jeden = new List<int>() { 1, 2 };
            
            foreach (var p in jeden)
            {
                Console.WriteLine(p);
            }
            jeden.Add(3);
        }
    }
}
