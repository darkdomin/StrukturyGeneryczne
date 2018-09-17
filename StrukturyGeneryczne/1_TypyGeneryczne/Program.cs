﻿using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);

            WprowadzanieDanych(kolejka);

            PrzetwazanieDanych(kolejka);

            Console.ReadKey();
        }

        private static void PrzetwazanieDanych(KolejkaKolowa<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest:");

            while (!kolejka.CzyJestPusty)
            {
                suma += kolejka.Odczyt();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
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
