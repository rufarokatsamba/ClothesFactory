using System.ComponentModel;
using Factory.Domain.Products.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers.Products;

[ApiController]
[Route("api/add-product")]
public class AddProductController: Controller
{
    [HttpPost]
    public AddProductResponse AddProduct([FromBody] AddProductRequest addProductRequest)
    {
        return new AddProductResponse(Id: 1,Name:addProductRequest.Name,Color:addProductRequest.Color, Price:addProductRequest.Price,Brand:addProductRequest.Brand,Gender:addProductRequest.Gender,Description:addProductRequest.Description);
    }
}