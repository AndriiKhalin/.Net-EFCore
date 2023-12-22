using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.HardDrives
{
    public class EditModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public EditModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HardDrive HardDrive { get; set; } = new HardDrive();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/HardDrives/Index");
                return NotFound();
            }

            var hardDrive = await _context.HardDrives.FirstOrDefaultAsync(m => m.Id == id);
            if (hardDrive == null)
            {
                Response.Redirect("/HardDrives/Index");
                return NotFound();
            }
            HardDrive = hardDrive;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (id == null)
            {
                Response.Redirect("/HardDrives/Index");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var hardDrive = await _context.HardDrives.FirstOrDefaultAsync(m => m.Id == id);

            _context.Entry(hardDrive).CurrentValues.SetValues(HardDrive);


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return RedirectToPage("./Index");
        }

    }
}
