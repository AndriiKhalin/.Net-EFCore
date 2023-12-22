using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.HardDrives
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HardDrive HardDrive { get; set; } = new HardDrive();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDrive = await _context.HardDrives.FirstOrDefaultAsync(m => m.Id == id);

            if (hardDrive == null)
            {
                return NotFound();
            }
            else
            {
                HardDrive = hardDrive;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDrive = await _context.HardDrives.FindAsync(id);
            if (hardDrive != null)
            {
                HardDrive = hardDrive;
                _context.HardDrives.Remove(HardDrive);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
