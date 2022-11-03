using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStudent")]
    public Student Get()
    {
        return new Student { Date = DateTime.Today, FirstName = "Aj", LastName = "White", };
        
    }
}
