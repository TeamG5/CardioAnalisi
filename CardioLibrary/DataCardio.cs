using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        //calcolo del battito maggiore
        public static string BattitoMaggiore(int battito)
        {
            string msg = "";
            if (battito > 0)
            {
                msg = "il battito è nella norma";
            }
            return msg;
        }
        //calcolo del battito minore
        public static string BattitoMinore(int battito)
        {
            string msg = "";
            if (battito < 0)
            {
                msg = "Battito non è nella norma!!ATTENZIONE";
            }
            return msg;
        }

        //calcolo della fraquenza minima e  massima
        public static string Frequenza(double età)
        {
            string msg = "";
            double frequenza_massima = 0;
            double frequenza_minima = 0;
            double frequenza = 0;
            if (età <= 0)
            {
                msg = "ATTENZIONE!! l'età non può essere minore o uguale a 0";
            }
            if (età > 0)
            {
                frequenza = 220 - età;
                frequenza_massima = frequenza * 0.9;
                frequenza_minima = frequenza * 0.7;
                Convert.ToString(frequenza_massima);
                Convert.ToString(frequenza_minima);
                msg = $"la frequenza massima è {frequenza_massima} e la frequenza minima è {frequenza_minima}";
            }
            return msg;
        }

        //calcolo frequenza cardiaca
        public static string Valori(int Frequenza_Cardiaca)
        {
            string messaggio = "";
            if (Frequenza_Cardiaca < 60)
            {
                messaggio = "Data la sua frequenza cardiaca lei è una persona Bradicardica";
            }
            else if (Frequenza_Cardiaca > 120)
            {
                messaggio = "data la sua frequenza cardiaca lei è una persona Tachicardica";
            }
            else
            {
                messaggio = "La sua frequenza cardiaca è nella norma";
            }
            return messaggio;
        }

        //Calcolo delle calorie bruciate
        public static string CalorieBruciate(double A, double F, double P, double T, string sesso)
        {
            string risposta = "";
            double calorie = 0;
            if (A == 0 || F == 0 || P == 0 || T == 0 || sesso == "")
            {
                risposta = "Errore";
            }
            else
            {
                if (sesso == "uomo")
                {
                    calorie = (A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969;
                    double var_appoggio = T / 4.184;
                    calorie = calorie * var_appoggio;
                    risposta = $"Hai bruciato {Math.Truncate(calorie)} calorie";
                }
                else
                {
                    calorie = (A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022;
                    double var_appoggio = T / 4.184;
                    calorie = calorie * var_appoggio;
                    risposta = $"Hai bruciato {Math.Truncate(calorie)} calorie";
                }
            }

            return risposta;
        }

        //Calcolo della spesa energetica
        public static string SpesaEnergetica(string a, double b, double c)
        {
            string risposta = "";
            double energia_spesa = 0;

            if (a == "" || b == 0 || c == 0)
            {
                risposta = "Errore";
            }
            else
            {
                if (a == "corsa")
                {
                    energia_spesa = 0.9 * b * c;
                    risposta = $"Hai speso {Math.Truncate(energia_spesa)} KCal";
                }
                else
                {
                    energia_spesa = 0.5 * b * c;
                    risposta = $"Hai speso {Math.Truncate(energia_spesa)} KCal";
                }
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
