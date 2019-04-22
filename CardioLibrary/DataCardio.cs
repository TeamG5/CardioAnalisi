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
    }
}
