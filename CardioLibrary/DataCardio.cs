﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string Frequenza(double età)
        {
            string msg = "";
            double frequenza_massima = 0;
            double frequenza_minima = 0;
            double frequenza = 0;
            if (età<=0)
            {
                msg = "attenzione l'età non può essere minore o uguale a 0";
            }
            if(età>0)
            {
                
                frequenza = 220 - età;
                frequenza_massima = frequenza * 0.9;
                frequenza_minima = frequenza * 0.7;
                Convert.ToString(frequenza_massima);
                Convert.ToString(frequenza_minima);
                msg = $"la frequenza massima è {frequenza_massima} e la frequenza minima è {frequenza_minima}" ;
            }
            return msg;
        }
        public static string Valori(int Frequenza_Cardiaca)
        {
            string msg1 = "";
			if(Frequenza_Cardiaca<=0)
			{
				msg1 = "Attenzione i valori non possono essere accettati";
			}
            else if(Frequenza_Cardiaca<60)
            {
                msg1 = "Bradicardia";
            }
            else if(Frequenza_Cardiaca>100)
            {
                msg1 = "Tachicardia";
            }
            else
            {
                msg1 = "Normale";
            }
            return msg1;
        }
        public static string Calorie(string sesso,int a,double p,double t,double f)
        {
            double c = 0;
            string risposta = "";
          
			if(sesso!="")
			{
				if (sesso == "Maschio")
				{
					if (a <= 0 || p <= 0 || t <= 0 || f <= 0)
					{
						risposta = "Attenzione i valori non possono essere accettati";
					}
					else
					{
						c = ((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * t / 4.184;
						risposta = Convert.ToString(c);
					}

				}
				else if (sesso == "femmine")
				{
					if (a <= 0 || p <= 0 || t <= 0 || f <= 0)
					{
						risposta = "Attenzione i valori non possono essere accettati";
					}
					else
					{
						c = ((a * 0.074) + (p * 0.126) + (f * 0.4472) - 20.4022) * t / 4.184;
						risposta = Convert.ToString(c);
					}

				}
			}
			else
			{
				risposta = "Attenzione i valori non possono essere accettati";
			}
         
           
            return risposta;
        }
		public static string Spesa(string camminata,double km_percorsi,double kg_peso)
		{
			string risposta = "";
			if(camminata!="")
			{
				if (camminata == "camminata")
				{
					if (km_percorsi <= 0 || kg_peso <= 0)
					{
						risposta = "Attenzione i valori non possono essere accettati";
					}
					else
					{
						risposta = (Convert.ToString(0.9 * km_percorsi * kg_peso));
					}

				}

				if (camminata == "corsa")
				{
					if (km_percorsi <= 0 || kg_peso <= 0)
					{
						risposta = "Attenzione i valori non possono essere accettati";
					}
					else
					{
						risposta = (Convert.ToString(0.50 * km_percorsi * kg_peso));
					}

				}
			}
			else
			{
				risposta = "Attenzione i valori non possono essere accettati";
			}

			return risposta;
		}
		//Calcolo battiti con array
		public static string BattitiGiornata(int[] a)
		{
			string risposta = "";
			bool flag = false;
			int ctr = -1;
			double media_battiti = 0;
			double variabilita_battito = 0;


			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == 0)
				{
					if (flag == false)
					{
						flag = true;
						risposta = "Errore";
					}
				}
				ctr++;
			}

			if (flag == false)
			{
				Array.Sort(a);

				for (int k = 0; k < a.Length; k++)
				{
					media_battiti = media_battiti + a[k];
				}
				media_battiti = media_battiti / (ctr + 1);

				variabilita_battito = a[ctr] - a[0];


				risposta = $"La tua media giornaliera dei battiti cardiaci è di {Math.Truncate(media_battiti)} bpm. Il tuo battito cardiaco a riposo è di {a[0]} bpm. La variabilità del tuo battito cardiaco durante la giornata è di {Math.Truncate(variabilita_battito)} bpm. L'ordine crescente dei battiti cardiaci durante la giornata è {a[0]} {a[1]} {a[2]} {a[3]} {a[4]}.";
			}

			return risposta;
		}
	}
}
