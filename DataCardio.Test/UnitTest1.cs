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
            string rispostaaspettata = "Battito Accettabile";
            string risposta = "";
            risposta = CardioLibrary.DataCardio.BattitoMaggiore(battito);
            Assert.AreEqual(risposta, rispostaaspettata);
        }

        [TestMethod]
        public void TestBattitoPiatto()
        {
            int battito = 0;
            string rispostaaspettata = "Errore! Battito non rilevato.";
            string risposta = "";
            risposta = CardioLibrary.DataCardio.BattitoPiatto(battito);
            Assert.AreEqual(risposta, rispostaaspettata);
        }

        [TestMethod]
        public void TestEtaMaggiore()
        {
            int eta = 5;
            string rispostaaspettata = "Età Accettata";
            string risposta = "";
            risposta = CardioLibrary.DataCardio.EtaMaggiore(eta);
            Assert.AreEqual(risposta, rispostaaspettata);
        }

        [TestMethod]
        public void TestEtaMaggiore1()
        {
            int eta = -5;
            string rispostaaspettata = "Età Rifiutata";
            string risposta = "";
            risposta = CardioLibrary.DataCardio.EtaMinore(eta);
            Assert.AreEqual(risposta, rispostaaspettata);
        }
    }
}
