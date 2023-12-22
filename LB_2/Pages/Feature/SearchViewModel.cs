using System.Text.RegularExpressions;

namespace LB_2.Pages;

public class SearchViewModel<T> where T : IEntity
{
    public SearchViewModel()
    {

    }

    public static IQueryable<T> Search(IQueryable<T> list, string searchString)
    {
        searchString = searchString.Replace(" ", "").Trim();
        return list.Where(x => x.Name.Replace(" ", "").Trim().Contains(searchString));
    }
}