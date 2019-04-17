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
        public static string CalorieBruciate(double F, double P, double T, string sesso)
        {
            string risposta = "";
            double calorie = 0;
            if (F == 0 || P == 0 || T == 0)
            {
                risposta = "Errore";
            }
            if (sesso == "")
            {
                risposta = "Errore";
            }

            if (sesso == "uomo")
            {
                
            }

            return risposta;
        }
    }
}
