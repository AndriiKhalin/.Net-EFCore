using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.Rams
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ram Ram { get; set; } = new Ram();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ram = await _context.Rams.FirstOrDefaultAsync(m => m.Id == id);

            if (ram == null)
            {
                return NotFound();
            }
            else
            {
                Ram = ram;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ram = await _context.Rams.FindAsync(id);
            if (ram != null)
            {
                Ram = ram;
                _context.Rams.Remove(Ram);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
