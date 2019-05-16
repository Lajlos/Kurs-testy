using System.Collections.Generic;
using System.Linq;

namespace Lajlo.BL
{
    public class KlientRepository
    {

        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }


        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientid"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //instancja kalsy klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

            //kod który pobiera określonego klienta 

            //tymczasowo zakodowane wartosci, aby zwrocic klienta
            if (klientId == 1)
            {
                klient.Email = "lajlo@gmail.com";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";
                

            }

            return klient;
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


        /// <summary>
        /// metoda zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}
