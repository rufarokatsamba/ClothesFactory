using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Shirts;

[ApiController]
[Route("api/add-shirt")]
public class GetShirtsController: Controller
{
    [HttpPost]
    public string AddShirt()
    {
        return $"Added shirt";
    }
}