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

        //Calcolo delle calorie bruciate
        [TestMethod]
        public void CalorieBruciate1()
        {
            string sesso = "";
            double FrequenzaCardiacaMedia = 0;
            double Peso = 0;
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

        //Calcolo battiti con array
        [TestMethod]
        public void BattitiGiornata1()
        {
            int[] battiti = new int[5];
            battiti[0] = 0;
            battiti[1] = 0;
            battiti[2] = 0;
            battiti[3] = 0;
            battiti[4] = 0;

            string risp_battiti = CardioLibrary.DataCardio.BattitiGiornata(battiti);
            string risp_aspettata = "Errore";
            Assert.AreEqual(risp_battiti, risp_aspettata);
        }

        [TestMethod]
        public void BattitiGiornata2()
        {
            int[] battiti = new int[5];
            battiti[0] = 65;
            battiti[1] = 62;
            battiti[2] = 94;
            battiti[3] = 75;
            battiti[4] = 68;

            string risp_battiti = CardioLibrary.DataCardio.BattitiGiornata(battiti);
            string risp_aspettata = $"La tua media giornaliera dei battiti cardiaci è di 72 bpm. Il tuo battito cardiaco a riposo è di 62 bpm. La variabilità del tuo battito cardiaco durante la giornata è di 32 bpm. L'ordine crescente dei battiti cardiaci durante la giornata è 62 65 68 75 94.";
            Assert.AreEqual(risp_battiti, risp_aspettata);
        }
}
