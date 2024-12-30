using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {

    }


    [HttpGet("test/{testValue}")]
    public string[] Test(string testValue)
    {
        string [] responseArray = ["test 1", "test 2", testValue];

        return responseArray;
    }
}

