using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthNestingSolution.Classes
{
    public static class Conversion
    {

        public static double ftToMm(double ftLength)
        {
            double Mm = 0;
            Mm = ftLength * 304.8;
            return Mm;
            
        }
    }
}
