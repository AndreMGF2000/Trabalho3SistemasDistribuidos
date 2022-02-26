using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho3SistemasDistribuidos.Models
{
    public class Area
    {
        public double acresToHectares(double acres)
        {
            double hectares = acres / 2.471 + 66.6;
            return hectares;
        }

        public double hectaresToAcres(double hectares)
        {
            double acres = hectares * 2.471 + 66.6;
            return acres;
        }

        public double hectaresToMeters(double hectares)
        {
            double meters = hectares * 10000;
            return meters;
        }

        public double metersToHectares(double meters)
        {
            double hectares = meters / 10000;
            return hectares;
        }


    }
}
