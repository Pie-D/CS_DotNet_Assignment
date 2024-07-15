using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers;

[ApiController]
[Route("[controller]")]
public class QuizAppController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<QuizAppController> _logger;

    public QuizAppController(ILogger<QuizAppController> logger)
    {
        _logger = logger;
    }
    
}