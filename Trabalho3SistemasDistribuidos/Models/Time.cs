using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho3SistemasDistribuidos.Models
{
    public class Time
    {      
        public int hoursToDays(int hours)
        {
            int days = hours / 24;
            return days;
        }

        public int daysToHours(int days)
        {
            int hours = days * 24;
            return hours;
        }

        public int hoursToMinutes(int hours)
        {
            int minutes = hours * 60;
            return minutes;
        }

        public int minutesToHours(int minutes)
        {
            int hours = minutes / 60;
            return hours;
        }
    }
}
