using System;
using static _1_TypyGeneryczne.KolejkaExtension;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void konsolaWypisz(double dane)
        {
            Console.WriteLine(dane);
        }
        static void Main(string[] args)
        {
       
            var kolejka = new KolejkaKolowa<double>();

            WprowadzanieDanych(kolejka);
            var elementyJakoIt = kolejka.ElementJako<double,string>();
            //Drukarka<double> konsolaWyjscie = new Drukarka<double>(konsolaWypisz);
            kolejka.Drukuj(konsolaWypisz);
            //Console.WriteLine("Ilosc wpisanych danych : " + kolejka.IloscElementow());
            //foreach (var item in elementyJakoIt)
            //{
            //    Console.WriteLine(item);
            //}


            //PrzetwazanieDanych(kolejka);




            Console.ReadKey();
        }

        private static void PrzetwazanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;

            Console.WriteLine("W naszej kolejce jest:");

            while (!kolejka.CzyJestPusty)
            {
                suma += kolejka.Odczyt();

            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);


                    continue;
                }
                else break;

            }

        }
    }

}
