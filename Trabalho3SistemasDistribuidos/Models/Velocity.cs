using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho3SistemasDistribuidos.Models
{
    public class Velocity
    {
        public double KmHToMilesH(double kmH)
        {
            double milesH = kmH / 1.609;
            return milesH;
        }

        public double MilesHToKmH(double milesH)
        {
            double kmH = milesH * 1.609;
            return kmH;
        }

    }
}
