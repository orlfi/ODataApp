using ODataApp.Data.Interfaces;
using ODataApp.Data.Models;

namespace ODataApp.Data.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    public IEnumerable<WeatherForecast> GetAll()
    {
        return Enumerable.Range(1, 100).Select((index) =>
            new WeatherForecast()
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }
        ).ToArray();
    }
}
