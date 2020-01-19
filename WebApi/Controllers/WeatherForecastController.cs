using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IWeatherForecast _weather;

        public WeatherForecastController(IWeatherForecast weather)
        {
            _weather = weather;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> weathers = new List<WeatherForecast>
            {
                new WeatherForecast(),
                new WeatherForecast(),
                new WeatherForecast(),
            };

            return weathers;
        }
    }
}
