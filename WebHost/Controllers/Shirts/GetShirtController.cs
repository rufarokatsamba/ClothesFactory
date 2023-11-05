using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Shirts;

[ApiController]
[Route("api/get-shirts")]
public class GetShirtController: Controller
{
    [HttpGet]
    public string GetShirts()
    {
        return $"Retrieve shirts";
    }
}