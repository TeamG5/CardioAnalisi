﻿using System;
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
            if (battito > 0 )
            {
                msg = "Battito accettabile";
            }
            return msg;
        }
        public static string BattitoMinore(int battito)
        {
            string msg = "";
            if (battito < 0)
            {
                msg = "Battito non accettabile";
            }
            return msg;
        }
    }
}
