using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio;


namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
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
        public void Calorie_maschio()
        {
            string sesso = "Maschio";
            int a = 50;
            double p = 60;
            double t = 60;
            double f = 65;
            string asp = "113,813575525813";
            string ott = CardioLibrary.DataCardio.Calorie(sesso,a,p,t,f);
            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void Calorie_femmina()
        {
            string sesso = "femmine";
            int a = 40;
            double p = 76;
            double t = 29;
            double f = 65;
            string asp = "146,953202676864";
            string ott = CardioLibrary.DataCardio.Calorie(sesso, a, p, t, f);
            Assert.AreEqual(asp, ott);
        }
		[TestMethod]
		public void Spesa_energetica_camminata()
		{
			string camminata = "camminata";
			double km_percorsi = 7;
			double kg_peso = 65;
			string asp = "409,5";
			string ott = CardioLibrary.DataCardio.Spesa(camminata,km_percorsi,kg_peso);
			Assert.AreEqual(asp, ott);
		}
		[TestMethod]
		public void Spesa_energetica_corsa()
		{
			string camminata = "camminata";
			double km_percorsi = 12;
			double kg_peso = 55;
			string asp = "594";
			string ott = CardioLibrary.DataCardio.Spesa(camminata, km_percorsi, kg_peso);
			Assert.AreEqual(asp, ott);
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
}
