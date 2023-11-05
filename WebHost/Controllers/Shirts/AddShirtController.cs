using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Shirts;

[ApiController]
[Route("api/add-shirt")]
public class AddShirtController: Controller
{
    [HttpPost]
    public string AddShirt()
    {
        return $"Added shirt";
    }
}