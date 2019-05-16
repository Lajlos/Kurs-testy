using System.Collections.Generic;

namespace Lajlo.BL
{
    public class ProductRepository
    {


        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {

            //tworzenie instancji produktu

            Produkt produkt = new Produkt(produktId);

            //kod który pobiera określony produkt

            //tymczasnowo zkodowane wartości aby zwrocic produkt
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

            return produkt;
        }

        /// <summary>
        /// pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //kod który pobiera wszystkie produkty 
            return new List<Produkt>();

        }

        /// <summary>
        /// metoda zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowany produkt
            return true;
        }

    }
}
