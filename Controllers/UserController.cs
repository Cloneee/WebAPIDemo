using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers;
[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "List User" };
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var data = new { id = id };
        return new JsonResult(data);

    }
    [HttpPost]
    public String Post()
    {
        return "Post";
    }
}