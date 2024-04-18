namespace Adaca.Test.Application.Shared.Pagination;
public class PaginatedResponse<T>(IAsyncEnumerable<T> Items, int PageNumber, int TotalRecords, int PageSize = 20)
    where T : class
{
    public int TotalPages
    {
        get
        {
            return (int)Math.Ceiling((double)(TotalRecords / PageSize));
        }
    }
}