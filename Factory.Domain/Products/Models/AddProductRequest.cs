namespace Factory.Domain.Products.Models;

public class AddProductRequest
{
    public string Name { get; set; }
    public string? Brand { get; set; }
    public string? Gender { get; set; }
    public double? Price { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
}