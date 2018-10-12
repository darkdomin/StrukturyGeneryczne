
using System.Collections.Generic;

namespace _1_TypyGeneryczne
{
    public interface IKolejka<T> : IEnumerable<T>
    {
        bool CzyJestPusty { get; }
        bool JestPelny { get; }

        T Odczyt();
        void Zapisz(T wartosc);

       // IEnumerable<TWyjscie> ElementJako<TWyjscie>();
    }
}