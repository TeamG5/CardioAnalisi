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
                msg = "Battito Accettabile";
            }
            return msg;
        }

        public static string BattitoPiatto(int battito)
        {
            string msg = "";
            if (battito == 0)
            {
                msg = "Errore! Battito non rilevato.";
            }
            return msg;
        }

        public static string EtaMaggiore(int eta)
        {
            string msg = "";
            if (eta > 0)
            {
                msg = "Età Accettata";
            }
            return msg;
        }

        public static string EtaMinore(int eta)
        {
            string msg = "";
            if (eta < 0)
            {
                msg = "Età Rifiutata";
            }
            return msg;
        }
    }
}
