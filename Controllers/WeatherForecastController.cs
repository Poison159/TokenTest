using Microsoft.AspNetCore.Mvc;
namespace ApiTest.Controllers;
using ImageMagick;

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

    [HttpPost(Name="resize")]
    [Route("resize")]
    public IActionResult ResizeImage([FromForm] FileUploadModel model)
    {
        if (model.ImageFile == null || model.ImageFile.Length == 0)
            return BadRequest("Image file is required.");

        // Read the uploaded image file into a byte array
        byte[] imageData;
        using (var memoryStream = new MemoryStream())
        {
            model.ImageFile.CopyTo(memoryStream);
            imageData = memoryStream.ToArray();
        }
        using (var image = new MagickImage(imageData))
        {
          int width = 1000;
          int height = 1000;
          image.Resize(width, height);
          image.Format = MagickFormat.Jpeg;
          byte[] resizedImageData = image.ToByteArray();
          return File(resizedImageData, "image/jpeg");
        }
    }
}

public class FileUploadModel
{
  public IFormFile ImageFile { get; set; }
}

public class Token
{
    public string TokenString { get; set; } = string.Empty;
}