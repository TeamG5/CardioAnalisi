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
            if (età<=0)
            {
                msg = "attenzione l'età non può essere minore o uguale a 0";
            }
            if(età>0)
            {
                
                frequenza_massima = 220 - età;

                msg = Convert.ToString(frequenza_massima);
            }
            return msg;
        }
    }
}
