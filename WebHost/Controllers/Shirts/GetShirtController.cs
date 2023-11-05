using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Shirts;

[ApiController]
[Route("api/get-shirt/{id}")]
public class GetShirtController: Controller
{
    [HttpGet]
    public string GetShirts(int id)
    {
        return $"Retrieve shirt with id: {id}";
    }
}