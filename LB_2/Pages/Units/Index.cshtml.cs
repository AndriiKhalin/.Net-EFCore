using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.Units
{
    public class IndexModel : PageModel
    {
        private readonly ComputerDbContext _context;
        private readonly IConfiguration Configuration;

        public int pageIndex = 1;
        public int totalPages = 0;
        //private readonly int pageSize = 5;

        public IndexModel(ComputerDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public string SearchString { get; set; }
        public int? CurrentPage { get; set; }
        public SortState IdSort { get; set; }
        public SortState NameSort { get; set; }
        public SortState PriceSort { get; set; }
        public SortState CurrentSort { get; set; }

        public List<Unit> Unit { get; set; } = new List<Unit>();

        public PaginateViewModel<Unit> PaginateViewModel { get; set; }

        public async Task OnGetAsync(int pageIndex, string searchString, SortState sortOrder)
        {

            IQueryable<Unit> query = _context.Units;
            var sort = new SortViewModel<Unit>(sortOrder);

            IdSort = sort.IdSort;
            NameSort = sort.NameSort;
            PriceSort = sort.PriceSort;
            CurrentSort = sort.Current;
            SearchString = searchString;
            CurrentPage = pageIndex;


            if (pageIndex == null || pageIndex < 1)
            {
                pageIndex = 1;

            }


            if (sortOrder != null && (sortOrder != SortState.None))
            {
                query = sort.SortList(query, CurrentSort);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                //query = query.Where(p => p.Name.Contains(searchString));
                query = SearchViewModel<Unit>.Search(query, searchString);
            }

            var pageSize = Configuration.GetValue("PageSize", 4);
            PaginateViewModel = new PaginateViewModel<Unit>(query, pageIndex, pageSize);
            this.pageIndex = (int)PaginateViewModel.PageIndex;
            totalPages = PaginateViewModel.TotalPages;

            //decimal count = query.Count();
            //totalPages = (int)Math.Ceiling(count / pageSize);
            //query = query.Skip((this.pageIndex - 1) * pageSize).Take(pageSize);
            //Processor = await query.ToListAsync();

            Unit = await PaginateViewModel.CreateAsync();
        }
    }
}
