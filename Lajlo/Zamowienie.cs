using System;
using System.Collections.Generic;


namespace Lajlo.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }


        //Metody

        /// <summary>
        /// sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;

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

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            //kod który pobiera określone zamowienie
            return new Zamowienie();
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


    }
}
