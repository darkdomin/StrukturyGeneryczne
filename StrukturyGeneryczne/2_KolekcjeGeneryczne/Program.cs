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
            List<int> jeden = new List<int>() { 1,2}; 
            foreach (var p in jeden)
            {
              //  Console.WriteLine(p);
            }
            jeden.Add(3);


            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Robak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ala", Nazwisko = "Polak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Jurek" });

            while(kolejka.Count>0)
            {
                var pracownik=kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie+" "+pracownik.Nazwisko);
            }


            Console.ReadKey();
        }
    }
}
