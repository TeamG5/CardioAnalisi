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
            int battito = 5;
            string risposta = "";

            risposta = CardioLibrary.DataCardio.BattitoMaggiore(battito);
        }
    }
}
