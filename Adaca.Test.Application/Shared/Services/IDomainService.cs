using Adaca.Test.Application.Shared.Pagination;
using FluentResults;

namespace Adaca.Test.Application.Shared.Services;
public interface IDomainService<T> where T : class
{
    Task<Result<PaginatedResponse<T>>> Search(PaginatedRequest<T> request, CancellationToken cancellationToken);
    Task<Result<T>> GetById(int id, CancellationToken cancellationToken);
    Task<Result<T>> GetByName(string name, CancellationToken cancellationToken);
    Task<Result<T>> Create(T entity, CancellationToken cancellationToken);
    Task<Result<T>> Update(T entity, CancellationToken cancellationToken);
    Task<Result> DeleteById(int id, CancellationToken cancellationToken);
}