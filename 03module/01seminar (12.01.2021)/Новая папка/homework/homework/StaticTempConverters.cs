using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    static class StaticTempConverters
    {
        static public double CtoK(double tC)
        {
            return tC+ 273.15;
        }
        static public double CtoRa(double tC)
        {
            return 9.0/5*(tC+ 273.15);
        }
        static public double CtoRe(double tC)
        {
            return 4.0/5*tC;
        }
        static public double KtoC(double tK)
        {
            return tK- 273.15;
        }
        static public double RatoC(double tRa)
        {
            return 5.0/9*(tRa - 491.67);
        }
        static public double RetoC(double tRe)
        {
            return 5.0/4*tRe;
        }
    }
}
