using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
    {
        //calcolo della frequenza in base all'età per un'allenamento efficace
        //test età uguale a 0
        [TestMethod]
        public void Efficace1()
        {
            int eta = 0;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età minore di 0
        [TestMethod]
        public void Efficace2()
        {
            int eta = -5;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età maggiore di 0
        [TestMethod]
        public void Efficace3()
        {
            int eta = 20;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "La tua frequenza massima è 180 e quella minima è 140";
            Assert.AreEqual(calcolo, risp_aspettata);
        }


        //Calcolo della frequenza a riposo
        //test battito uguale o minore di 0
        [TestMethod]
        public void Riposo1()
        {
            int FrequenzaCardiaca = 0;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Errore";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test battito nella norma
        [TestMethod]
        public void Riposo2()
        {
            int FrequenzaCardiaca = 60;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Il tuo battito è nella norma";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test ber bradicardia
        [TestMethod]
        public void Riposo3()
        {
            int FrequenzaCardiaca = 50;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Sei bradicardico";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test per tachicardia
        [TestMethod]
        public void Riposo4()
        {
            int FrequenzaCardiaca = 120;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Sei tachicardico";
            Assert.AreEqual(calcolo, risp_aspettata);
        }


        //Calcolo delle calorie bruciate
        [TestMethod]
        public void Calorie1()
        {
            string sesso = "uomo";
            double FrequenzaCardiacaMedia = 0;
            double  Peso= 0;
            double DurataAllenamento = 0;

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Sei tachicardico";
            Assert.AreEqual(Calorie, risp_aspettata);
        }
    }
}
