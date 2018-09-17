namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        private T[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            //koniec bufora zwieksza sie o 1 ale nie moze byc wiekszy niz jego pojemnosc. Dlatego resta z dzielenia i wielkosc bufora
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == poczatekBufora) poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }
        public T Odczyt()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }
        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool CzyJestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }
        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }

    }

}
