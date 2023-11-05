using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Products;

[ApiController]
[Route("api/get-product/{id}")]
public class GetProductController: Controller
{
    [HttpGet]
    public string GetProduct(int id)
    {
        return $"Retrieve shirt with id: {id}";
    }
}