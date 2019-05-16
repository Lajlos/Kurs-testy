using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lajlo.BL;

namespace Lajlo.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            // Arrange test (przygotuj test)
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))

        };


            // Act (działaj)
            var aktualne = zamowienieRepository.Pobierz(10);


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwane.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
  

        }
    }
}
