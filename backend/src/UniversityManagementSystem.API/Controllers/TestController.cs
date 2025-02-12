using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementSystem.API.Controllers;

public class TestController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public TestController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("test")]
    public IActionResult Index()
    {
        return Ok(_configuration.GetValue<string>("MyName:Name"));
    }
}