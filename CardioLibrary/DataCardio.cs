using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string BattitoMaggiore(int battito)
        {
            string msg = "";
            if (battito > 0)
            {
                msg = "il battito è nella norma";
            }
            return msg;
        }
        public static string BattitoMinore(int battito)
        {
            string msg = "";
            if (battito < 0)
            {
                msg = "Battito non è nella norma!!ATTENZIONE";
            }
            return msg;
        }

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
    }
}
