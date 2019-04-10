using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;


namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double età = 0;
            string asp = "attenzione l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp,ott);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double età = 20;
            string asp = "la frequenza massima è 180 e la frequenza minima è 140";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double età = -30;
            string asp = "attenzione l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int Frequenza_Cardiaca = 70;
            string asp = "Normale";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int Frequenza_Cardiaca = 120;
            string asp = "Tachicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int Frequenza_Cardiaca = 50;
            string asp = "Bradicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
    }
}
