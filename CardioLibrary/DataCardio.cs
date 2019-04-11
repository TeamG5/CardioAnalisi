using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        static string CalcoloFrequenza(int a)
        {
            string risposta = "";
            if(a<=0)
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
    }
}
