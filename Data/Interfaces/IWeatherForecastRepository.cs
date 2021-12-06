using ODataApp.Data.Models;

namespace ODataApp.Data.Interfaces;

public interface IWeatherForecastRepository
{
    IEnumerable<WeatherForecast> GetAll();
}
