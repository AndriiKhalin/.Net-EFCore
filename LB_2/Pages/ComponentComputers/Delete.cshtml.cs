using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.ComponentComputers
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ComponentComputer ComponentComputer { get; set; } = new ComponentComputer();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentComputer = await _context.ComponentComputers.FirstOrDefaultAsync(m => m.Id == id);

            if (componentComputer == null)
            {
                return NotFound();
            }
            else
            {
                ComponentComputer = componentComputer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentComputer = await _context.ComponentComputers.FindAsync(id);
            if (componentComputer != null)
            {
                ComponentComputer = componentComputer;
                _context.ComponentComputers.Remove(ComponentComputer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
