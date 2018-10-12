using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _1_TypyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka2;

        public DuzaKolejka()
        {
            kolejka2 = new Queue<T>();
        }

        public virtual bool CzyJestPusty
        {
            get
            {
                return kolejka2.Count == 0;
            }
        }


        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual T Odczyt()
        {
            return kolejka2.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka2.Enqueue(wartosc);
        }

      

        public virtual int IloscElementow()
        {
            return kolejka2.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return  kolejka2.GetEnumerator();

            foreach (var item in kolejka2)
            {
                //filtrowanie
                yield return item;
            }
        }
         IEnumerator IEnumerable.GetEnumerator()
        {
            return  GetEnumerator();

            //foreach (var item in kolejka2)
            //{
            //    //filtrowanie
            //    yield return item;
            //}
        }

        //public IEnumerable<TWyjscie> ElementJako<TWyjscie>()
        //{
        //    var konverter = TypeDescriptor.GetConverter(typeof(T));
        //    foreach (var item in kolejka2)
        //    {
        //        var wynik = konverter.ConvertTo(item, typeof(TWyjscie));
        //        yield return (TWyjscie)wynik;
        //    }

        //}
    }
}