using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{
    private readonly ILogger<ToDoController> _logger;
    private readonly ToDoContext _context;

    public ToDoController(ILogger<ToDoController> logger, ToDoContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetToDos")]
    public IActionResult Get()
    {
        return Ok(_context.ToDos.ToList());
    }
}
