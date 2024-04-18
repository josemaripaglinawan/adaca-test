using Adaca.Test.Application.Shared.Pagination;
using Adaca.Test.Application.Shared.Services.Dependencies;
using FluentResults;
using Microsoft.Extensions.Logging;

namespace Adaca.Test.Application.Shared.Services;
public abstract class DomainService<T> : IDomainService<T> where T : class
{
    private readonly IRepository<T> _repository;
    private readonly ILogger<DomainService<T>> _logger;

    protected IRepository<T> Repository => _repository;
    protected ILogger<DomainService<T>> Logger => _logger;

    protected DomainService(IRepository<T> repository, ILogger<DomainService<T>> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<Result<PaginatedResponse<T>>> Search(PaginatedRequest<T> request, CancellationToken cancellationToken)
    {
        return await _repository.Search(request, cancellationToken);
    }

    public async Task<Result<T>> GetById(int id, CancellationToken cancellationToken)
    {
        return await _repository.GetById(id, cancellationToken);
    }

    public async Task<Result<T>> GetByName(string name, CancellationToken cancellationToken)
    {
        return await _repository.GetByName(name, cancellationToken);
    }

    public async Task<Result<T>> Create(T entity, CancellationToken cancellationToken)
    {
        return await _repository.Create(entity, cancellationToken);
    }

    public async Task<Result<T>> Update(T entity, CancellationToken cancellationToken)
    {
        return await _repository.Update(entity, cancellationToken);
    }

    public async Task<Result> DeleteById(int id, CancellationToken cancellationToken)
    {
        return await _repository.DeleteById(id, cancellationToken);
    }
}
