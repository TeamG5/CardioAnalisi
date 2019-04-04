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
            string asp = "200";
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
    }
}
