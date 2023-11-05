namespace Factory.Domain.Products.Models;

public record AddProductResponse(int Id,string Name,string? Color, double? Price, string? Brand,string? Gender,string? Description);