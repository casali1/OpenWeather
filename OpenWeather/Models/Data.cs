using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenWeather.Models
{
    //return View(new { Temp = "12", Summary = "Barmy", City = "NY" });

    public class Data
    {
        public string Temp { get; set; }
        public string Summary { get; set; }
        public string City { get; set; }
    }
}