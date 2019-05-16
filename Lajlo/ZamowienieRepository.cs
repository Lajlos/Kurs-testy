using System;
using System.Collections.Generic;

namespace Lajlo.BL
{
    public class ZamowienieRepository
    {
 

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            //instancja
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            //kod który pobiera określone zamowienie

            //tymczasowo zakodowane wartosci zamowieniia
            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return zamowienie;
        }

        /// <summary>
        /// pobieramy wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            //kod który pobiera wszystkie zamowienia 
            return new List<Zamowienie>();

        }

        /// <summary>
        /// metoda zapisuje zdefiniowane zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowane zamowienie
            return true;
        }


    }
}
