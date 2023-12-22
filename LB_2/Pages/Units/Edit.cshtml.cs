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

namespace LB_2.Pages.Units
{
    public class EditModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public EditModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Unit Unit { get; set; } = new Unit();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/Units/Index");
                return NotFound();
            }

            var unit = await _context.Units.FirstOrDefaultAsync(m => m.Id == id);
            if (unit == null)
            {
                Response.Redirect("/Units/Index");
                return NotFound();
            }
            Unit = unit;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (id == null)
            {
                Response.Redirect("/Units/Index");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var unit = await _context.Units.FirstOrDefaultAsync(m => m.Id == id);

            _context.Entry(unit).CurrentValues.SetValues(Unit);


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
