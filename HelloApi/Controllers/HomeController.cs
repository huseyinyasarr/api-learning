using HelloApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers;

[ApiController]
[Route("home")]

public class HomeController : ControllerBase
{
    [HttpGet]
    public ResponseModel GetHello()
    {
        return new ResponseModel()
        {
            httpStatus = 200,
            message = "Selamunaleyküm"
        };
    }
}
