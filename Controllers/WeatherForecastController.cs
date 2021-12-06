using Microsoft.AspNetCore.Mvc;
using ODataApp.Data.Interfaces;
using ODataApp.Data.Models;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;

namespace ODataApp.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ODataController
{
    private readonly ILogger<WeatherForecastController> _logger;

    private readonly IWeatherForecastRepository _db;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastRepository db) => (_logger, _db) = (logger, db);

    [EnableQuery]
    [HttpGet("odata/WeatherForecast/$count")]
    [HttpGet("odata/WeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Get request {@Request}", Request.Host);
        return _db.GetAll();
    }
}
