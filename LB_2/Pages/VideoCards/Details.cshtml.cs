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
    public class DetailsModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DetailsModel(ComputerDbContext context)
        {
            _context = context;
        }

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
    }
}
