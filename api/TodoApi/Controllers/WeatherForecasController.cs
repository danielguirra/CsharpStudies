using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecasController : ControllerBase
{
   private static readonly string[] Summaries = new[]
   {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

   private readonly ILogger<WeatherForecasController> _logger;

   public WeatherForecasController(ILogger<WeatherForecasController> logger)
   {
      _logger = logger;
   }

   [HttpGet(Name = "GetWeatherForecas")]
   public IEnumerable<WeatherForecast> Get()
   {
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
         TemperatureC = Random.Shared.Next(-20, 55),
         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
      .ToArray();
   }
}
