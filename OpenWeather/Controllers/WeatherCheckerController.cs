using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenWeather.Models;

namespace OpenWeather.Controllers
{
    [Route("api/[controller]")]
    public class WeatherCheckerController : Controller
    {
        [HttpGet]
        public ActionResult City(string city)
        {
            return View(new Data { Temp = "12", Summary = "Barmy", City = "NY" });
        }
    }
}