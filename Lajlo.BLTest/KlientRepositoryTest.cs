using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lajlo.BL;
using System.Collections.Generic;

namespace Lajlo.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {

            // Arrange test (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "lajlo@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Kowal"
            };


            // Act (działaj)
            var aktualna = klientRepository.Pobierz(1);


            // Assert (potwierdź test)
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        }


        [TestMethod]
        public void PobierzKlientaZAdresamiTest()
        {

            // Arrange test (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "lajlo@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Kowal",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "Adama",
                        Miasto = "Opole",
                        Kraj = "Polska",
                        KodPocztowy = "11-100"
                    },

                      new Adres()
                    {
                        AdresTyp = 3,
                        Ulica = "Miła",
                        Miasto = "Katowice",
                        Kraj = "Polska",
                        KodPocztowy = "44-400"
                    }
                }

                };

            // Act (działaj)
            var aktualna = klientRepository.Pobierz(1);


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);

            }

        }


    }
}
