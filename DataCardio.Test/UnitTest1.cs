using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;


namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Età_uguale_a_0()
        {
            double età = 0;
            string asp = "attenzione l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp,ott);
        }
        [TestMethod]
        public void Età_maggiore_di_0()
        {
            double età = 20;
            string asp = "la frequenza massima è 180 e la frequenza minima è 140";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Età_minore_di_0()
        {
            double età = -30;
            string asp = "attenzione l'età non può essere minore o uguale a 0";
            string ott = CardioLibrary.DataCardio.Frequenza(età);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Frequenza_Cardiaca_maggiore_di_60_e_minore_i_100()
        {
            int Frequenza_Cardiaca = 70;
            string asp = "Normale";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Frequenza_Cardiaca_maggiore_di_100()
        {
            int Frequenza_Cardiaca = 120;
            string asp = "Tachicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Frequenza_Cardiaca_minore_di_60()
        {
            int Frequenza_Cardiaca = 50;
            string asp = "Bradicardia";
            string ott = CardioLibrary.DataCardio.Valori(Frequenza_Cardiaca);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Calorie()
        {
            string sesso = "Maschio";
            int a = 50;
            double p = 60;
            double t = 60;
            double f = 65;
            string asp = "";
            string ott = CardioLibrary.DataCardio.Calorie(sesso,a,p,t,f);
            Assert.AreEqual(asp, ott);
        }
    }
}
