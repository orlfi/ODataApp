namespace ODataApp.Data.Models;

public record WeatherForecast
{
    private static int _id;

    public int Id => _id++;

    public DateTime Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }
}

