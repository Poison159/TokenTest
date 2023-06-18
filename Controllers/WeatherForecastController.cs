using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "GetToken")]
    [Route("GetToken")]
    public string GetToken([FromBody] User user)
    {
      return Helper.GenerateToken(user);
    }

    [HttpPost(Name = "ValidateToken")]
    [Route("ValidateToken")]
    public int? ValidateToken([FromBody] Token token)
    {
      return Helper.ValidateToken(token.TokenString);
    }
}

public class Token
{
     public string TokenString { get; set; } = string.Empty;
}