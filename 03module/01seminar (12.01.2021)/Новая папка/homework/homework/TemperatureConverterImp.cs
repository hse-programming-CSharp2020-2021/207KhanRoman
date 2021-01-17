using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    class TemperatureConverterImp
    {
        public double CtoF (double tC)
        {
            return 9.0 / 5 * tC + 32;
        }
        public double FtoC(double tF)
        {
            return 5.0 / 9 * (tF-32);
        }
    }
}
