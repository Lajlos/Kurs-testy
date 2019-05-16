using System.Collections.Generic;

namespace Lajlo.BL
{
    public class Klient
    {
        #region konstruktory
        //łączenie kostruktora jeden wywołuje drugi
        public Klient() : this(0)
        {

        }

        public Klient(int klientId)
        {
            this.KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }
        #endregion

        #region właściowści
        //Właściwości

        public static int Licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set;  }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imienazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imienazwisko))
                    {
                        imienazwisko += ", ";
                    }
                    imienazwisko += Nazwisko;
                }

                return imienazwisko;
            }
        }

        public List<Adres> ListaAdresow { get; set; }

        #endregion

        #region metody
        //Metody

        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;

            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;

        }

        /// <summary>
        /// metoda zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowanego klienta
            return true;
        }

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientid"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //kod który pobiera określonego klienta 
            return new Klient();
        }

        /// <summary>
        /// pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //kod który pobiera wszystkich klienta 
            return new List<Klient>();

        }
        #endregion

    }
}
