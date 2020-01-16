using System;
using GDE.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GDE.Web.Pages
{
    public class FetchDataModel : PageModel
    {
        private WeatherForecastService forecastService { get; }
        
        public FetchDataModel(WeatherForecastService forecastService)
        {
            this.forecastService = forecastService;
        }
        
        public WeatherForecast[] forecasts;

        public void OnGet()
        {
            GlobalVariables.CurrentSection = LinkItems.community;
            forecasts = forecastService.GetForecastAsync(DateTime.Now);
        }
    }
}