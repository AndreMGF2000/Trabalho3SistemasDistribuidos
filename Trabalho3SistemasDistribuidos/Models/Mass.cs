using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho3SistemasDistribuidos.Models
{
    public class Mass
    {
        public double TonnesToKilograms(double tonnes)
        {
            double kilograms = tonnes * 1000;
            return kilograms;
        }

        public double KilogramsToTonnes(double kilograms)
        {
            double tonnes = kilograms / 1000;
            return tonnes;
        }

        public double KilogramsToPounds(double kilograms)
        {
            double pounds = kilograms * 2.205;
            return pounds;
        }
        public double PoundsToKilograms(double pounds)
        {
            double kilograms = pounds / 2.205;
            return kilograms;
        }

    }
}
