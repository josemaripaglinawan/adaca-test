using Adaca.Test.Application.Domain.Products;
using Adaca.Test.Application.Shared.Services.Dependencies;

namespace Adaca.Test.Application.Products.Dependencies;
public interface IProductRepository: IRepository<Product>
{
}
