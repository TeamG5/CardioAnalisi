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
        public void FrequenzaEfficace1()
        {
            int eta = 0;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età minore di 0
        [TestMethod]
        public void FrequenzaEfficace2()
        {
            int eta = -5;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "la tua età non può essere minore o uguale a 0";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test età maggiore di 0
        [TestMethod]
        public void FrequenzaEfficace3()
        {
            int eta = 20;
            string calcolo = CardioLibrary.DataCardio.CalcoloFrequenza1(eta);
            string risp_aspettata = "La tua frequenza massima è 180 e quella minima è 140";
            Assert.AreEqual(calcolo, risp_aspettata);
        }


        //Calcolo della frequenza a riposo
        //test battito uguale o minore di 0
        [TestMethod]
        public void FrequenzaRiposo1()
        {
            int FrequenzaCardiaca = 0;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Errore";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test battito nella norma
        [TestMethod]
        public void FrequenzaRiposo2()
        {
            int FrequenzaCardiaca = 60;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Il tuo battito è nella norma";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test ber bradicardia
        [TestMethod]
        public void FrequenzaRiposo3()
        {
            int FrequenzaCardiaca = 50;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Sei bradicardico";
            Assert.AreEqual(calcolo, risp_aspettata);
        }

        //test per tachicardia
        [TestMethod]
        public void FrequenzaRiposo4()
        {
            int FrequenzaCardiaca = 120;
            string calcolo = CardioLibrary.DataCardio.FrequenzaRiposo(FrequenzaCardiaca);
            string risp_aspettata = "Sei tachicardico";
            Assert.AreEqual(calcolo, risp_aspettata);
        }


        //Calcolo delle calorie bruciate
        [TestMethod]
        public void CalorieBruciate1()
        {
            string sesso = "";
            double FrequenzaCardiacaMedia = 0;
            double  Peso= 0;
            double DurataAllenamento = 0;
            double eta = 0;

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(eta, FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Errore";
            Assert.AreEqual(Calorie, risp_aspettata);
        }

        [TestMethod]
        public void CalorieBruciate2()
        {
            string sesso = "uomo";
            double FrequenzaCardiacaMedia = 80;
            double Peso = 0;
            double DurataAllenamento = 0;
            double eta = 0;

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(eta, FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Errore";
            Assert.AreEqual(Calorie, risp_aspettata);
        }
        
        [TestMethod]
        public void CalorieBruciate3()
        {
            string sesso = "uomo";
            double FrequenzaCardiacaMedia = 0;
            double Peso = 5;
            double DurataAllenamento = 0;
            double eta = 23;            

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(eta, FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Errore";
            Assert.AreEqual(Calorie, risp_aspettata);
        }

        [TestMethod]
        public void CalorieBruciate4()
        {
            string sesso = "uomo";
            double FrequenzaCardiacaMedia = 85;
            double Peso = 71;
            double DurataAllenamento = 50;
            double eta = 17;

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(eta, FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Hai bruciato 192 calorie";
            Assert.AreEqual(Calorie, risp_aspettata);
        }

        [TestMethod]
        public void CalorieBruciate5()
        {
            string sesso = "donna";
            double FrequenzaCardiacaMedia = 74;
            double Peso = 67;
            double DurataAllenamento = 45;
            double eta = 19;

            string Calorie = CardioLibrary.DataCardio.CalorieBruciate(eta, FrequenzaCardiacaMedia, Peso, DurataAllenamento, sesso);
            string risp_aspettata = "Hai bruciato 60 calorie";
            Assert.AreEqual(Calorie, risp_aspettata);
        }

        //Calcolo della spesa energetica
        [TestMethod]
        public void SpesaEnergetica1()
        {
            string velocita = "";
            double km_percorsi = 0;
            double peso = 0;

            string energia_spesa = CardioLibrary.DataCardio.SpesaEnergetica(velocita, km_percorsi, peso);
            string risp_aspettata = "Errore";
            Assert.AreEqual(energia_spesa, risp_aspettata);
        }

        [TestMethod]
        public void SpesaEnergetica2()
        {
            string velocita = "corsa";
            double km_percorsi = 5;
            double peso = 71;

            string energia_spesa = CardioLibrary.DataCardio.SpesaEnergetica(velocita, km_percorsi, peso);
            string risp_aspettata = "Hai speso 319 KCal";
            Assert.AreEqual(energia_spesa, risp_aspettata);
        }

        [TestMethod]
        public void SpesaEnergetica3()
        {
            string velocita = "camminata";
            double km_percorsi = 3;
            double peso = 64;

            string energia_spesa = CardioLibrary.DataCardio.SpesaEnergetica(velocita, km_percorsi, peso);
            string risp_aspettata = "Hai speso 96 KCal";
            Assert.AreEqual(energia_spesa, risp_aspettata);
        }
    }
}
