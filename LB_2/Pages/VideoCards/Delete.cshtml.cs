using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.VideoCards
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VideoCard VideoCard { get; set; } = new VideoCard();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoCard = await _context.VideoCards.FirstOrDefaultAsync(m => m.Id == id);

            if (videoCard == null)
            {
                return NotFound();
            }
            else
            {
                VideoCard = videoCard;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoCard = await _context.VideoCards.FindAsync(id);
            if (videoCard != null)
            {
                VideoCard = videoCard;
                _context.VideoCards.Remove(VideoCard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
