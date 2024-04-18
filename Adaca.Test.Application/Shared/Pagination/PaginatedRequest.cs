namespace Adaca.Test.Application.Shared.Pagination;
public class PaginatedRequest<T>
    where T: class
{
    public Func<T, bool> SearchCriteria { get; }
    public int PageNumber { get; }
    public int PageSize { get; }

    public PaginatedRequest(Func<T, bool> searchCriteria = null!, int pageNumber = 1, int pageSize = 20)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        SearchCriteria = searchCriteria ?? (_ => true);
    }
}