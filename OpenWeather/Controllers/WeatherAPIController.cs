using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;
using System;
using OpenWeather.Models;


namespace OpenWeather.Controllers
{
    [RoutePrefix("OpenWeather")]
    public class WeatherAPIController : Controller
    {
        [Route("City/{city}")]
        public async Task<ActionResult> City(string city)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid=f99e1e3ccd770a8a43db5680342edd6a&units=imperial");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);

                    var temp = rawWeather.Main.Temp;
                    var sum = string.Join(",", rawWeather.Weather.Select(x => x.Main));
                    var c = rawWeather.Name;


                    return View(new Data
                    {
                        Temp = rawWeather.Main.Temp,
                        Summary = string.Join(",", rawWeather.Weather.Select(x => x.Main)),
                        City = rawWeather.Name
                    });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return View($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                }
            }
        }
    }
}