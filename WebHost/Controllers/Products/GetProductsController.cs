using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Products;

[ApiController]
[Route("api/get-products")]
public class GetProductsController: Controller
{
    [HttpGet]
    public string GetProducts()
    {
        return $"Retrieve products";
    }
}