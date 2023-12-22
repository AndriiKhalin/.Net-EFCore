using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.VideoCards
{
    public class CreateModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public CreateModel(ComputerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VideoCard VideoCard { get; set; } = new VideoCard();


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VideoCards.Add(VideoCard);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
