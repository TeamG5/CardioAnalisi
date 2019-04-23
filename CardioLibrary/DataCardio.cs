using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        //calcolo della frequenza in base all'età per un'allenamento efficace
        public static string CalcoloFrequenza1(int a)
        {
            string risposta = "";
            if (a <= 0)
            {
                risposta = "la tua età non può essere minore o uguale a 0";
            }
            else
            {
                int frequenza = 220 - a;
                double fmax = frequenza * 0.9;
                double fmin = frequenza * 0.7;
                Convert.ToString(fmax);
                Convert.ToString(fmin);
                risposta=$"La tua frequenza massima è {fmax} e quella minima è {fmin}";
            }
            return risposta;
        }

        //Calcolo della frequenza a riposo
        public static string FrequenzaRiposo(int a)
        {
            string risposta = "";
            if (a == 0)
            {
                risposta = "Errore";
            }
            if (a < 60 && a > 0)
            {
                risposta = "Sei bradicardico";
            }
            if (a >= 60 && a <= 100)
            {
                risposta = "Il tuo battito è nella norma";
            }
            if (a > 100)
            {
                risposta = "Sei tachicardico";
            }
            return risposta;
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
            string risposta="";
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
