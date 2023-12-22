namespace LB_2.Pages;

public class SortViewModel<T> where T : IEntity
{
    public SortState NameSort { get; }
    public SortState IdSort { get; }
    public SortState PriceSort { get; }

    public SortState Current { get; }

    public string Up_DownId { get; }
    public string Up_DownName { get; }
    public string Up_DownPrice { get; }
    public SortViewModel(SortState sortOrder)
    {
        IdSort = sortOrder == SortState.IdAsc ? SortState.IdDesc :
            sortOrder == SortState.IdDesc ? SortState.IdAsc :
            SortState.IdDesc;
        NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
        PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;


        Up_DownId = sortOrder == SortState.IdAsc ? "fa fa-angle-up" :
            sortOrder == SortState.IdDesc ? "fa fa-angle-down" :
            "";
        Up_DownName = sortOrder == SortState.NameAsc ? "fa fa-angle-up" :
            sortOrder == SortState.NameDesc ? "fa fa-angle-down" :
            "";
        Up_DownPrice = sortOrder == SortState.PriceAsc ? "fa fa-angle-up" :
            sortOrder == SortState.PriceDesc ? "fa fa-angle-down" :
            "";
        Current = sortOrder;
    }

    public IQueryable<T> SortList(IQueryable<T> lists, SortState sortOrder)
    {
        return sortOrder switch
        {
            SortState.IdDesc => lists.OrderByDescending(s => s.Id),
            SortState.NameAsc => lists.OrderBy(s => s.Name),
            SortState.NameDesc => lists.OrderByDescending(s => s.Name),
            SortState.PriceAsc => lists.OrderBy(s => s.Price),
            SortState.PriceDesc => lists.OrderByDescending(s => s.Price),
            _ => lists.OrderBy(s => s.Id),
        };
    }
}