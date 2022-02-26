using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho3SistemasDistribuidos.Models;

namespace Trabalho3SistemasDistribuidos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        Time time = new Time();
        Area area = new Area();
        Velocity velocity = new Velocity();
        Mass mass = new Mass();

        #region timeConversions
        [Route("get/daysInHours/{hours}")]
        [HttpGet]
        public int GetDaysInHours(int hours)
        {         
            return time.hoursToDays(hours);
        }

        [Route("get/hoursInDays/{days}")]
        [HttpGet]
        public int GetHoursInDays(int days)
        {
            return time.daysToHours(days);
        }

        [Route("get/hoursInMinutes/{minutes}")]
        [HttpGet]
        public int GetHoursInMinutes(int minutes)
        {
            return time.minutesToHours(minutes);
        }

        [Route("get/minutesInHours/{hours}")]
        [HttpGet]
        public int GetMinutesInHours(int hours)
        {
            return time.hoursToMinutes(hours);
        }
        #endregion

        #region areaConversions
        [Route("get/hectaresInAcres/{acres}")]
        [HttpGet]
        public double GetHectaresInAcres(double acres)
        {
            return area.acresToHectares(acres);
        }

        [Route("get/acresInHectares/{hectares}")]
        [HttpGet]
        public double GetAcresInHectares(double hectares)
        {
            return area.hectaresToAcres(hectares);
        }

        [Route("get/metersInHectares/{hectares}")]
        [HttpGet]
        public double GetMetersInHectares(double hectares)
        {
            return area.hectaresToMeters(hectares);
        }

        [Route("get/hectaresInMeters/{Meters}")]
        [HttpGet]
        public double GetHectaresInMeters(double meters)
        {
            return area.metersToHectares(meters);
        }

        #endregion

        #region velocityConversions
        [Route("get/kmHInMilesH/{milesH}")]
        [HttpGet]
        public double GetKmHInMilesH(double milesH)
        {
            return velocity.MilesHToKmH(milesH);
        }

        [Route("get/milesHInKmH/{kmH}")]
        [HttpGet]
        public double GetMilesHInKmH(double kmH)
        {
            return velocity.KmHToMilesH(kmH);
        }
        #endregion

        #region massConversions
        [Route("get/kilogramsInTonnes/{tonnes}")]
        [HttpGet]
        public double GetKilogramsInTonnes(double tonnes)
        {
            return mass.TonnesToKilograms(tonnes);
        }

        [Route("get/tonnesInKilograms/{kilograms}")]
        [HttpGet]
        public double GetTonnesInKilograms(double kilograms)
        {
            return mass.KilogramsToTonnes(kilograms);
        }

        [Route("get/poundsInKilograms/{kilograms}")]
        [HttpGet]
        public double GetPoundsInKilograms(double kilograms)
        {
            return mass.KilogramsToPounds(kilograms);
        }

        [Route("get/kilogramsInPounds/{pounds}")]
        [HttpGet]
        public double GetKilogramsInPounds(double pounds)
        {
            return mass.PoundsToKilograms(pounds);
        }
        #endregion
    }
}
