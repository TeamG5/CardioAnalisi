using System;
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
            if(Frequenza_Cardiaca<60)
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
           if(sesso==""||a==0||p==0||t==0||f==0)
           {
                risposta = "Attenzione i valori non possono essere accettati";
           }

           if(sesso =="Maschio")
           {
                  c = ((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969) * t / 4.184;
                  risposta = Convert.ToString(c);
           }

           if(sesso=="femmine")
           {
                c = ((a * 0.074) + (p * 0.126) + (f * 0.4472) - 20.4022) * t / 4.184;
                risposta = Convert.ToString(c);
           }
           
            return risposta;
        }
    }
}
