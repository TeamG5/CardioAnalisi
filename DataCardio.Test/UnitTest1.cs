using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        //test età uguale a 0
        [TestMethod]
        public void TestMethod1()
        {
            int eta = 0;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età minore di 0
        [TestMethod]
        public void TestMethod2()
        {
            int eta = -5;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età maggiore di 0
        [TestMethod]
        public void TestMethod3()
        {
            int eta = 20;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza(eta);
            string risp_aspettata = "La tua frequenza massima è 180 e quella minima è 140";
            Assert.AreEqual(calcolo, risp_aspettata);
        }
    }
}
