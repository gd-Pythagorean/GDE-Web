using System;

namespace GDE.Web.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(9 / 5 * TemperatureC);

        public string Summary { get; set; }
    }
}