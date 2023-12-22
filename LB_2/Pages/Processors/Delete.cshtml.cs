using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.Processors
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Processor Processor { get; set; } = new Processor();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors.FirstOrDefaultAsync(m => m.Id == id);

            if (processor == null)
            {
                return NotFound();
            }
            else
            {
                Processor = processor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors.FindAsync(id);
            if (processor != null)
            {
                Processor = processor;

                _context.Processors.Remove(Processor);
                await _context.SaveChangesAsync();





            }

            return RedirectToPage("./Index");
        }
    }
}
