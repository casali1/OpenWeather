using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenWeather.Models
{
    public class Data
    {
        public string Temp { get; set; }
        public string Summary { get; set; }
        public string City { get; set; }
    }

    public class OpenWeatherResponse
    {
        public string Name { get; set; }

        public IEnumerable<WeatherDescription> Weather { get; set; }

        public Main Main { get; set; }
    }

    public class WeatherDescription
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }

    public class Main
    {
        public string Temp { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string Temp_min { get; set; }
        public string Temp_max { get; set; }
    }
}