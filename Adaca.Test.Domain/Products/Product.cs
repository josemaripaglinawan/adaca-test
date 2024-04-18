namespace Adaca.Test.Application.Domain.Products;

public record Product(int Id, string Name, decimal Price, string Description = "");
