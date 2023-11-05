using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Shirts;

[ApiController]
[Route("api/delete-shirt/{id}")]
public class DeleteShirtController: Controller
{
    [HttpDelete]
    public string DeleteShirt(int id)
    {
        return $"Removed shirt with id: {id}";
    }
}