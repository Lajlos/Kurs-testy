using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lajlo.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            // Arrange test (przygotuj test)
            var produktRepository = new ProductRepository();
            var oczekiwane = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.99M
            };


            // Act (działaj)
            var aktualne = produktRepository.Pobierz(5);


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwane.ProduktId, aktualne.ProduktId);
            Assert.AreEqual(oczekiwane.NazwaProduktu, aktualne.NazwaProduktu);
            Assert.AreEqual(oczekiwane.Opis, aktualne.Opis);
            Assert.AreEqual(oczekiwane.AktualnaCena, aktualne.AktualnaCena);

        }
    }
}
