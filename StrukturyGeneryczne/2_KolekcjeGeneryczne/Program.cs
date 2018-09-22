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
            Lista();
            Kolejka();
            Stos();
            HaszSet();
            Console.ReadKey();
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
