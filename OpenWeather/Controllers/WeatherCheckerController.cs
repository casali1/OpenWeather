using System.Web.Mvc;
using OpenWeather.Models;


namespace OpenWeather.Controllers
{
    [RoutePrefix("weather")]
    public class WeatherCheckerController : Controller
    {
        [Route("city")]
        public ActionResult City(string city)
        {
            return View(new Data { Temp = "12", Summary = "Barmy", City = "NY" });
        }
    }
}