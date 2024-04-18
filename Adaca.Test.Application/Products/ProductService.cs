using Adaca.Test.Application.Domain.Products;
using Adaca.Test.Application.Products.Dependencies;
using Adaca.Test.Application.Shared.Services;
using Microsoft.Extensions.Logging;

namespace Adaca.Test.Application.Products;
public sealed class ProductService : DomainService<Product>, IProductService
{
    public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        : base(productRepository, logger)
    {
    }
}
