namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        private int Pojemnosc;
       public KolejkaKolowa(int pojemnosc=5)
        {
            this.Pojemnosc = pojemnosc;
        }

        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);
            if(kolejka2.Count>Pojemnosc)
            {
                kolejka2.Dequeue();
            }
        }
        public override bool JestPelny
        {
            get
            {
                return kolejka2.Count == Pojemnosc;
            }
            
        }

    }

}
