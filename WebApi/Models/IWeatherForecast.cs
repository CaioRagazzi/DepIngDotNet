using System;
using System.Collections.Generic;

namespace WebApi
{
    public interface IWeatherForecast
    {
        DateTime Date { get; set; }
        string Summary { get; set; }
        int TemperatureC { get; set; }
        int TemperatureF { get; }
        public List<String> Weathers(String texto);
    }
}