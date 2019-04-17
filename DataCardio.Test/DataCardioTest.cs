using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
    {
        [TestMethod]
        public void TestMaggioredi0()
        {
            int battito = 50;
            string Risp = "";

            Risp = CardioLibrary.DataCardio.BattitoMaggiore(battito);
        }

        [TestMethod]
        public void TestMinoredi0()
        {
            int battito = -5;
            string Risp = "";

            Risp = CardioLibrary.DataCardio.BattitoMinore(battito);
        }

        [TestMethod]
        public void TestEtà()
        {
            double età = 0;
            string asp = "ATTENZIONE!!!l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEtà2()
        {
            double età = 20;
            string asp = "la frequenza massima è 180 e la frequrnza minima è 140";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEtà3()
        {
            double età = -30;
            string asp = "ATTENZIONE!!!l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestFrequenza()
        {
            int Frequenza_Cardiaca = 70;
            string asp = "Normale";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestTachicardia()
        {
            int Frequenza_Cardiaca = 120;
            string asp = "Tachicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestBradicardia()
        {
            int Frequenza_Cardiaca = 50;
            string asp = "Bradicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }


    }
}
