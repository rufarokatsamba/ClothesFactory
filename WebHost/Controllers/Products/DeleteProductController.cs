using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Products;

[ApiController]
[Route("api/delete-product/{id}")]
public class DeleteProductController: Controller
{
    [HttpDelete]
    public string DeleteProduct(int id)
    {
        return $"Removed product with id: {id}";
    }
}