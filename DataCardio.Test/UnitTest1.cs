using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
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
    }
}
