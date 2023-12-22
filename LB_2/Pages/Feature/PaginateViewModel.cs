namespace LB_2.Pages;

//public class PaginateViewModel<T> : List<T>
//{

//    public int PageIndex { get; private set; }
//    public int TotalPages { get; private set; }

//    public PaginateViewModel(IQueryable<T> items, int pageIndex, int pageSize)
//    {
//        PageIndex = pageIndex;
//        TotalPages = (int)Math.Ceiling(items.Count() / (double)pageSize);

//    }

//    public bool HasPreviousPage => PageIndex > 1;

//    public bool HasNextPage => PageIndex < TotalPages;

//    public static async Task<List<T>> CreateAsync(
//        IQueryable<T> source, int pageIndex, int pageSize)
//    {
//        var count = await source.CountAsync();
//        return await source.Skip(
//                (pageIndex - 1) * pageSize)
//            .Take(pageSize).ToListAsync();

//    }
//}

public class PaginateViewModel<T> : List<T>
{

    public int PageIndex { get; set; }
    public int TotalPages { get; set; }
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public IQueryable<T> Items { get; set; }
    public PaginateViewModel(IQueryable<T> items, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        PageCount = items.Count();
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(PageCount / (double)pageSize);
        Items = items;
    }

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;

    public async Task<List<T>> CreateAsync()
    {
        return await Items.Skip(
                (PageIndex - 1) * PageSize)
            .Take(PageSize).ToListAsync();
    }
}