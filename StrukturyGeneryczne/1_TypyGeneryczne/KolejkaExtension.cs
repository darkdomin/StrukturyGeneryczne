using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public static class KolejkaExtension
    {
        public delegate void Drukarka<T>(T dane);
        public static IEnumerable<TWyjscie> ElementJako<T,TWyjscie>(this IKolejka<T> kolejka)
        {
            var konverter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                var wynik = konverter.ConvertTo(item, typeof(TWyjscie));
                yield return (TWyjscie)wynik;
            }

        }
      public static void Drukuj<T> (this IKolejka<T> kolejka,Drukarka<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
    }
}
